# 概要

このソフトは、yt-dlp.exeとffmpeg.exeを利用した動画のダウンロードを支援するソフトです。

コマンドプロンプト起動機能(cdコマンド不要)、ファイル移動機能があります。

"YouTube"となっていますが、yt-dlp.exeの機能で他のサイトの動画もダウンロードできます。

## yt-dlp.exeについて

yt-dlp[(GitHub)](https://github.com/yt-dlp/yt-dlp)はYoutube-dl[(GitHub)](https://github.com/ytdl-org/youtube-dl)のFork(派生)として作られたフリーソフトウェアです。

Youtube-dlは更新があまりされていなく、[YouTube側から速度制限を受けている](https://github.com/ytdl-org/youtube-dl/issues/30097)ため、制限を回避しているyt-dlpを使用します。

存在しない場合、最新のyt-dlp.exeが[GitHub - Releases](https://github.com/yt-dlp/yt-dlp/releases)からダウンロードされます。


## ffmpeg.exeについて

FFmpeg[(公式サイト)](https://ffmpeg.org/)は動画と音声を記録・変換・再生するためのフリーソフトウェアです。多くのソフトに付属しています。

公式からはソースコードのみ提供されており、このソフトでは[gyan.dev](https://www.gyan.dev/ffmpeg/builds/)のffmpeg-5.1.2-full_build.7z(ffmpeg-git-full.7z)のffmpeg.exeとLICENSE、README.txtをzip圧縮したものを同梱しています。

# 使い方

YouTubeDownloader.exeを起動してください。表示される文に従ってください。新たにコンソールが表示されます。

下のほうに解説サイト集あります。

## メイン

コピペ用に置いときます。解説サイト集のを参考にしてください。

##### yt-dlp [URL] -f mp4

適当にmp4保存。

##### yt-dlp [URL] -x --audio-format mp3

適当にmp3保存。

## 他

##### yt-dlp --help

ヘルプが表示されます。かなり詳しいとこまで見たい人向け。

##### yt-dlp --extractor-descriptions

対応サイト一覧が表示されます(一部説明付き)。かなりあるのでぜひ見てください。

## 解説サイト集

youtube-dlはyt-dlpに置き換えてください。

[knooto - youtube-dl の使い方 (YouTube の動画・音声をコマンドラインでダウンロードする)](https://knooto.info/youtube-dl/)　youtube-dlのものですがわかりやすいです。

[†MASAYOSHI†のオンラインメモ帳 - youtube-dl オプション一覧及びそのメモ](https://masayoshi-9a7ee.hatenablog.com/entry/20150905/1441414821)　こちらもyoutube-dlのものですがかなりの量が載っています。


# 再配布・改変について

yt-dlp.exe・ffmpeg.exeはそれぞれライセンスを確認してください。私が作ったところは改変・再配布自由です。

# サイト等

[GitHub](https://github.com/Ichihai1415/YouTubeDownloader)　ソースコード・ソフトの配布のほか、修正予定・バグ情報をIssuesで公開します。

[Twitter](https://twitter.com/ProjectS31415_1)　エラーが発生した場合報告ください。質問も受け付けています。
