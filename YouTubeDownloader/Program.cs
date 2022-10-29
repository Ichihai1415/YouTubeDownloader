using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeDownloader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(!File.Exists("yt-dlp.exe"))
            {
                WebClient WC = new WebClient();
                Console.WriteLine("yt-dlp.exeをダウンロードしています...");
                WC.DownloadFile($"https://github.com/yt-dlp/yt-dlp/releases/download/latest/yt-dlp.exe", "yt-dlp.exe");
                Console.WriteLine("yt-dlp.exeのダウンロードが完了しました。");

            }






        }
    }
}
