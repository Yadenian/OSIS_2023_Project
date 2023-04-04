using System;
using System.Windows.Forms;

namespace DiagnosticProgram
{
    public partial class MainForm : Form
    {
        private readonly Diagnotor _drivesDiagnotor;
        private DiagnotorState _diagState;
        private int _updateCount;

        public MainForm()
        {
            InitializeComponent();

            _drivesDiagnotor = new Diagnotor();
            _drivesDiagnotor.UpdateInterval = 5000;
            _drivesDiagnotor.Drive = "F";
            _drivesDiagnotor.StateChanged += DrivesDiagnotor_StateChanged;
            _drivesDiagnotor.InfoUpdated += DrivesDiagnotor_InfoUpdated;

            updateIntervalTb.Text = _drivesDiagnotor.UpdateInterval.ToString();
        }

        private void DrivesDiagnotor_InfoUpdated(object sender, DiagnosticInfoEventArgs e)
        {
            _updateCount++;
            totalSizeTb.Text = e.DriveInfo.TotalSize.ToString();
            availableFreeSpaceTb.Text = e.DriveInfo.AvailableFreeSpace.ToString();
            updateCountLabel.Text = _updateCount.ToString();
        }

        private void DrivesDiagnotor_StateChanged(object sender, DiagnotorState e)
        {
            _diagState = e;
            diagStateInfoLb.Text = e.ToString();
        }

        private void RunDiagnosticButton_Click(object sender, EventArgs e)
        {
            if (_diagState != DiagnotorState.Running)
            {
                if (_diagState == DiagnotorState.Stopped)
                {
                    MessageBox.Show("Monitoring thread stopped");
                    return;
                }

                _drivesDiagnotor.Start();
            }
            else
            {
                _drivesDiagnotor.Pause();
            }
        }

        private void StopDiagButton_Click(object sender, EventArgs e)
        {
            _drivesDiagnotor.Stop();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _drivesDiagnotor.Stop();
        }

        private void ApplyNewIntervalBtn_Click(object sender, EventArgs e)
        {
            int interval;
            if (int.TryParse(updateIntervalTb.Text, out interval))
            {
                if (interval > -1)
                {
                    _drivesDiagnotor.UpdateInterval = interval;
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
