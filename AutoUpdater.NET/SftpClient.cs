using Renci.SshNet;
using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
namespace AutoUpdaterDotNET
{
    public class SftpDownClient : IDownClient
    {
        private SftpClient Client;
        public SftpDownClient(SftpConfig config)
        {
            Client = new SftpClient(config.Host, config.Port, config.UserName, config.Password);
        }

        #region IDownClient接口
        public WebHeaderCollection ResponseHeaders => null;

        public Uri ResponseUri { get; set; }

        public bool IsBusy  {get;set;}=false;

        public event DownloadProgressChangedEventHandler DownloadProgressChanged;
        public event AsyncCompletedEventHandler DownloadFileCompleted;

        public void CancelAsync()
        {

        }
        
        /// <summary>
        /// 下载文件
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="tempFile"></param>
        public void DownloadFileAsync(string uri, string tempFile)
        {
            var t=Task.Run(() =>
            {
                IsBusy = true;
                Uri downUrl = new Uri(uri);
                ResponseUri = downUrl;

                    this.Connect();

                    using (FileStream fileStream = new FileStream(tempFile, FileMode.Open))
                    {
                        var file = Client.GetAttributes(downUrl.PathAndQuery);
                        Client.DownloadFile(downUrl.PathAndQuery, fileStream, size =>
                        {
                            var vPercent = (int)((long)(size * 100) / file.Size);
                            //
                            var args = new DownloadProgressChangedEventArgs(vPercent, null, (long)size, file.Size);
                            DownloadProgressChanged(this, args);
                        });
                        fileStream.Close();
                    }
                    this.Disconnect();
                IsBusy = false;


            });
            t.ContinueWith(t => {

                AsyncCompletedEventArgs asyncCompleted;
                if (t.IsFaulted)
                {
                    asyncCompleted = new AsyncCompletedEventArgs(t.Exception, false, null);
                }
                else if(t.IsCanceled)
                {
                    asyncCompleted = new AsyncCompletedEventArgs(null, true, null);
                }
                else
                {
                    asyncCompleted = new AsyncCompletedEventArgs(null, false, null);
                }
                DownloadFileCompleted(this, asyncCompleted);
            });
        }

        /// <summary>
        /// 下载版本信息
        /// </summary>
        /// <param name="baseUri"></param>
        /// <returns></returns>
        public string DownloadString(string baseUri)
        {
            var versionInfo = string.Empty;
            this.Connect();

            string cachefile = "temp.xml";
            if (File.Exists(cachefile))
            {
                File.Delete(cachefile);
            }
            using (FileStream fileStream = new FileStream(cachefile, FileMode.Create))
            {
                Client.DownloadFile(baseUri, fileStream);
                fileStream.Close();
            }
            versionInfo = File.ReadAllText(cachefile);
            this.Disconnect();
            return versionInfo;
        }

        #endregion

        /// <summary>
        /// 连接SFTP服务器
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool Connect()
        {
            bool result;

            bool flag = !this.Client.IsConnected;
            if (flag)
            {
                this.Client.Connect();
            }
            result = true;

            return result;
        }
        /// <summary>
        /// 断开连接
        /// </summary>
        public void Disconnect()
        {

            bool flag = this.Client != null && this.Client.IsConnected;
            if (flag)
            {
                this.Client.Disconnect();
            }

        }
    }
}
