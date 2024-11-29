using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AutoUpdaterDotNET
{
    /// <summary>
    /// 下载器
    /// </summary>
    public interface IDownClient
    {
        #nullable enable
        /// <summary>
        /// event
        /// </summary>
        event DownloadProgressChangedEventHandler? DownloadProgressChanged;
        /// <summary>
        /// 
        /// </summary>
        event AsyncCompletedEventHandler? DownloadFileCompleted;
        #nullable enable
        /// <summary>
        /// 
        /// </summary>
        WebHeaderCollection? ResponseHeaders { get; }
        /// <summary>
        /// 
        /// </summary>
        Uri ResponseUri { get; }
        /// <summary>
        /// 
        /// </summary>
        bool IsBusy { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="tempFile"></param>
        void DownloadFileAsync(string uri, string tempFile);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseUri"></param>
        /// <returns></returns>
        string DownloadString(string baseUri);

        /// <summary>
        /// 
        /// </summary>
        void CancelAsync();
    }
}
