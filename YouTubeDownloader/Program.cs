using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace YouTubeDownloader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("YouTubeDownloader v1.0.0");
            Console.WriteLine("使い方はREADME.mdを参照してください。");
            if (File.Exists("ffmpeg.zip")&& !File.Exists("ffmpeg.exe"))
            {
                Console.WriteLine("ffmpeg.zipを解凍しています...");
                ZipFile.ExtractToDirectory("ffmpeg.zip", Directory.GetCurrentDirectory());
                Console.WriteLine("ffmpeg.zipの解凍が終了しました。");
                File.Delete("ffmpeg.zip");
                Console.WriteLine("ffmpeg.zipを削除しました。");
            }
            if (!File.Exists("yt-dlp.exe"))
            {
                WebClient WC = new WebClient();
                Console.WriteLine("yt-dlp.exeをダウンロードしています...");
                WC.DownloadFile($"https://github.com/yt-dlp/yt-dlp/releases/latest/download/yt-dlp.exe", "yt-dlp.exe");
                Console.WriteLine("yt-dlp.exeのダウンロードが完了しました。");
            }
            if (!Directory.Exists("output"))
                Directory.CreateDirectory("output");
            Console.WriteLine("コマンドプロンプトを起動しています...");
            Thread.Sleep(1000);
            Process.Start("cmd.exe");
            while (true)
            {
                Console.WriteLine("ファイルを移動する場合、ディレクトリ名を入力してください。(output\\)");
                string ToDirectry = Console.ReadLine();
                if (ToDirectry != "")
                    ToDirectry = "\\" + ToDirectry;
                Console.WriteLine("移動する拡張子を入力してください。※区切りは\",\"(例:mp4,mp3)");
                string[] Extensions = Console.ReadLine().Split(',');
                List<string> Files = new List<string>();
                for (int i = 0; i < Extensions.Length; i++)
                    Files.AddRange(Directory.GetFiles(Directory.GetCurrentDirectory(), $"*.{Extensions[i]}", SearchOption.AllDirectories).ToList());
                Console.WriteLine("移動中");
                for (int i = 0; i < Files.Count; i++)
                {
                    Console.WriteLine(Files[i]);
                    if (!Directory.Exists("output"+ToDirectry))
                        Directory.CreateDirectory("output"+ToDirectry);
                    File.Move(Files[i], Files[i].Replace(Directory.GetCurrentDirectory(),$"{Directory.GetCurrentDirectory()}\\output{ToDirectry}"));
                }
                Console.WriteLine("移動終了しました。");

            }
        }
    }
}
