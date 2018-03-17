# PrivateVideoFomatTransformation
youku private format video to open format
程序基于dot net framework框架 4.6.
转码时需要安装优酷pc版客户端.
1.选择优酷安装文件夹中的nplayer子文件夹中的ffmpeg.exe程序.
2.选择需要转换的优酷私有格式视频所在目录,程序会自行搜索该文件夹和其中子文件夹中的文件.
3.选择输出文件夹
4.开始转换,等待完成.

此程序相当于一个命令行生成工具,由于我不会写复杂的bat文件,只能用c#程序来代替.
参考命令行如下
"C:\Program Files (x86)\YouKu\YoukuClient\nplayer\ffmpeg.exe" -y -i "F:\电影\xxx乐队_1080p.kux" -c:v copy -c:a copy -threads 2
"F:\电影\xxx乐队_1080p.kux.mp4"
作者：知乎用户
链接：https://www.zhihu.com/question/51792949/answer/298412575
来源：知乎
著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
