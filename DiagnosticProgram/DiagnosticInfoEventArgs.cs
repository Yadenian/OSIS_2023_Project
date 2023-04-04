using System;
using System.IO;

namespace DiagnosticProgram
{
    public class DiagnosticInfoEventArgs : EventArgs
    {
        public DiagnosticInfoEventArgs(DriveInfo driveInfo)
        {
            DriveInfo = driveInfo;
        }

        public DriveInfo DriveInfo { get; protected set; }
    }
}