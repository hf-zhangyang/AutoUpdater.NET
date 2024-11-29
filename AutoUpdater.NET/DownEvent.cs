using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoUpdaterDotNET
{
    public class DownloadProgressChangedEventArgs : ProgressChangedEventArgs
    {
        public DownloadProgressChangedEventArgs(int progressPercentage, object? userToken, long bytesReceived, long totalBytesToReceive) :
            base(progressPercentage, userToken)
        {
            BytesReceived = bytesReceived;
            TotalBytesToReceive = totalBytesToReceive;
        }

        public long BytesReceived { get; }
        public long TotalBytesToReceive { get; }
    }

    public delegate void DownloadProgressChangedEventHandler(object sender, DownloadProgressChangedEventArgs e);
}
