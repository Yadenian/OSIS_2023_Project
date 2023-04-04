using System;
using System.Diagnostics;
using System.IO;

namespace DiagnosticProgram // Типа пошутил :)
{
    public class Diagnotor : WorkerBase
    {
        public string Drive { get; set; }

        public event EventHandler<DiagnosticInfoEventArgs> InfoUpdated;

        protected override void Update()
        {
            var drives = new DriveInfo(Drive);
            OnInfoUpdated(new DiagnosticInfoEventArgs(drives));
        }

        protected void OnInfoUpdated(DiagnosticInfoEventArgs e)
        {
            Debug.WriteLine("OnInfoUpdated");

            var handler = InfoUpdated;
            if (handler != null)
            {
                _syncContext.Post((state) =>
                {
                    handler(this, (DiagnosticInfoEventArgs)state);
                }, e);
            }
        }
    }
}
