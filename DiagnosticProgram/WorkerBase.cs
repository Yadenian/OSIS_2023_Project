using System;
using System.Diagnostics;
using System.Threading;

namespace DiagnosticProgram
{
    /// <summary>
    /// Базовый класс, который выполняет работу заданную в реализации абстрактного метода <see cref="Update"/> (в классе наследнике). 
    /// Класс позволяет запустить поток, приостановить и полностью остановить (прекратить работу потока).
    /// </summary>
    public abstract class WorkerBase
    {
        private volatile bool _paused;
        private volatile bool _canWork = true;

        private readonly Thread _diagThread;
        private readonly ManualResetEventSlim _pauseEvent;
        private readonly ManualResetEventSlim _threadSleepEvent;

        protected readonly SynchronizationContext _syncContext;
        private volatile int _updateInterval;

        protected WorkerBase()
        {
            _syncContext = SynchronizationContext.Current;

            _pauseEvent = new ManualResetEventSlim();
            _threadSleepEvent = new ManualResetEventSlim();
            _diagThread = new Thread(Run) { IsBackground = true };

            OnStateChanged(DiagnotorState.Initialized);
        }


        /// <summary>
        /// Интервал обновления метода <see cref="Update"/>. 
        /// В случае присвоения нового значения ожидание с предыдущим значением интервала прерывается, 
        /// выполняется метод <see cref="Update"/> и срабатывает пауза уже с новым значением.
        /// </summary>
        public int UpdateInterval
        {
            get
            {
                return _updateInterval;

            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Update interval must be 0 or greater");
                }

                _updateInterval = value;

                // Прерываем ожидание потока с предыдущим интервалом
                _threadSleepEvent.Set();

            }
        }

        public event EventHandler<DiagnotorState> StateChanged;

        public void Start()
        {
            if (!_diagThread.IsAlive)
            {
                _diagThread.Start();
            }

            if (!_pauseEvent.IsSet)
            {
                _pauseEvent.Set();
            }

            Debug.WriteLine("Start");
        }

        public void Pause()
        {
            _pauseEvent.Reset();
            _threadSleepEvent.Set();
            _paused = true;

            Debug.WriteLine("Pause");
        }

        /// <summary>
        /// Полностью завершить работу потока.
        /// </summary>
        public void Stop()
        {
            _canWork = false;

            if (!_pauseEvent.IsSet)
            {
                _pauseEvent.Set();
            }

            if (!_threadSleepEvent.IsSet)
            {
                _threadSleepEvent.Set();
            }

            Debug.WriteLine("Stop");
        }

        private void Run(object obj)
        {
            OnStateChanged(DiagnotorState.Running);

            do
            {
                Debug.WriteLine("New iteration of method \"Run\"");

                if (_paused)
                {
                    OnStateChanged(DiagnotorState.Paused);
                    _pauseEvent.Wait();
                    _paused = false;
                    if (!_canWork)
                    {
                        break;
                    }
                    OnStateChanged(DiagnotorState.Running);
                }

                int updateInterval = UpdateInterval;
                if (updateInterval > 0)
                {
                    Debug.WriteLine(string.Format("Thread.Sleep({0})", updateInterval.ToString()));
                    _threadSleepEvent.Wait(updateInterval);
                    _threadSleepEvent.Reset();
                    Debug.WriteLine("Resume update");
                }

                if (_canWork)
                {
                    Debug.WriteLine("Start method \"Update\"");
                    Update();
                }

            } while (_canWork);

            OnStateChanged(DiagnotorState.Stopped);
        }

        protected void OnStateChanged(DiagnotorState e)
        {
            Debug.WriteLine("New state: " + e.ToString());

            var handler = StateChanged;
            if (handler != null)
            {
                _syncContext.Post((state) =>
                {
                    handler(this, (DiagnotorState)state);
                }, e);
            }
        }

        /// <summary>
        /// Метод, выполняющий некоторую работу, заданную в классе наследнике с интервалом заданным в свойстве <see cref="UpdateInterval"/>.
        /// </summary>
        protected abstract void Update();
    }
}