using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.IO.Packaging;
using System.IO.Compression;
using ICSharpCode.SharpZipLib.Zip;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            startDownload();


        }
        private void startDownload()
        {
            Thread thread = new Thread(() =>
            {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                client.DownloadFileAsync(new Uri("http://lumeria.ru/vscaner/vscaner.zip"), @"update.zip");
            });
            thread.Start();
        }
        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                double bytesIn = double.Parse(e.BytesReceived.ToString());
                double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = bytesIn / totalBytes * 100;
                label2.Text = "Загруженно " + e.BytesReceived + " из " + e.TotalBytesToReceive;
                progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
            });
        }
        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                label2.Text = "Готово";
                startUpdate();
            });
        }
        private void startUpdate()
        {
            Process[] ps1 = System.Diagnostics.Process.GetProcessesByName("VeganCheck"); //Имя процесса
            foreach (Process p1 in ps1)
            {
                p1.Kill();
            }
            Thread.Sleep(5000);
            System.IO.File.Delete(@"VeganCheck.exe");
            Thread.Sleep(5000);
            
            DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory());
            FastZipUnpack("update.zip", di.ToString());
            Process.Start("VeganCheck.exe");
            Application.Exit();

        }
        public void FastZipUnpack(string zipFileName, string targetDir)
        {

            FastZip fastZip = new FastZip();
            string fileFilter = null;
            fastZip.ExtractZip(zipFileName, targetDir, fileFilter);
        }
       
      
        
    }
}
 
