using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace PrivateVideoFomatTransformation
{
    public partial class MainForm : Form
    {
        private StringBuilder strBuilder;
        private List<string> fliterWord;
        private List<string> pFormatVideos;

        public MainForm()
        {
            InitializeComponent();
            //命令参数创建器
            strBuilder=new StringBuilder();
            //过滤用扩展名后缀
            fliterWord=new List<string>(){ ".kux", ".qsv" };
            pFormatVideos=new List<string>();

        }

        private void btnPrivateFFMPEG_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd=new OpenFileDialog();
            ofd.Filter = "应用程序(*.exe)|*.exe";
            if (ofd.ShowDialog()==DialogResult.OK)
            {
                if (ofd.FileName.ToLower().Contains("ffmpeg.exe"))
                {
                    tbPrivateFFMPEG.Text = ofd.FileName;
                }
                else
                {
                    MessageBox.Show("正确的ffmpeg程序文件名应该为\"ffmpeg.exe\"", "提示", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                   // tbMessage.Text = "正确的ffmpeg程序文件名应该为\"ffmpeg.exe\"";
                }
            }
        }

        private void btnPrivateFormatVideoFolder_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog fbd=new FolderBrowserDialog();
            if (fbd.ShowDialog()==DialogResult.OK)
            {
                pFormatVideos.Clear();
                tbPrivateFomatVideoFolder.Text = string.Empty;
                SearchFile(new DirectoryInfo(fbd.SelectedPath),pFormatVideos,fliterWord);
                if (pFormatVideos.Count>0)
                {
                    tbPrivateFomatVideoFolder.Text = fbd.SelectedPath;
                    strBuilder.Clear();
                    pFormatVideos.ForEach(file => { strBuilder.AppendLine($"已找到私有格式文件:{file}"); });
                    tbMessage.Text = strBuilder.ToString();
                }
                else
                {
                    MessageBox.Show("当前选择的文件夹没有需要转换的私有格式视频文件,请重新选择文件夹", "提示", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void btnOutputFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                tbOutputFolder.Text = fbd.SelectedPath;
                
            }
        }

        private void btnTransformation_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbPrivateFFMPEG.Text))
            {
                MessageBox.Show("没有选择私有ffmpeg程序文件", "提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (pFormatVideos.Count==0)
            {
                MessageBox.Show("没有需要转换的文件", "提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(tbOutputFolder.Text))
            {
                MessageBox.Show("没有选择输出文件夹", "提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DirectoryInfo oDir=new DirectoryInfo(tbOutputFolder.Text);

            if (!oDir.Exists)
            {
                MessageBox.Show("输出文件夹不存在或者无法访问", "提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                tbOutputFolder.Text=String.Empty;
                return;
            }

             int threadNumber;
                if (int.TryParse(tbThreadNumber.Text,out threadNumber))
                {
                    
                }
                else
                {
                    threadNumber = 4;
                }

            foreach (var pFormatVideo in pFormatVideos)
            {
                tbMessage.Text += $"\r\n开始转换:{pFormatVideo}";
                string oName = pFormatVideo.Replace(tbPrivateFomatVideoFolder.Text, tbOutputFolder.Text)+".mp4";
                TransformathionVideo(tbPrivateFFMPEG.Text,pFormatVideo,
                    oName,threadNumber);
                tbMessage.Text += $"\r\n完成转换:{oName}";
            }
            tbPrivateFomatVideoFolder.Text=String.Empty;
            pFormatVideos.Clear();
            
        }

        /// <summary>
        /// 查找文件
        /// </summary>
        /// <param name="dir"></param>
        /// <param name="result"></param>
        /// <param name="fliter"></param>
        private void SearchFile(DirectoryInfo dir,List<string> result,List<string> fliter)
        {
            if (!dir.Exists)
            {
                return;
                ;
            }
            else
            {
                FileInfo[] findFiles = dir.GetFiles();
                foreach (var findFile in findFiles)
                {
                    if (fliter.Contains(findFile.Extension))
                    {
                        result.Add(findFile.FullName);
                    }
                }
                DirectoryInfo[] findDirectorys = dir.GetDirectories();
                foreach (var findDirectory in findDirectorys)
                {
                        SearchFile(findDirectory,result,fliter);
                }
            }
        }


        private void TransformathionVideo(string ffmpeg, string pVideo, string video, int tNumber)
        {
            System.Diagnostics.Process exep = new System.Diagnostics.Process();
            exep.StartInfo.FileName = ffmpeg;
            exep.StartInfo.Arguments = $"-y -i {pVideo} -c:a copy -c:v copy -threads {tNumber} {video}";
            exep.StartInfo.CreateNoWindow = true;
            exep.StartInfo.UseShellExecute = false;
            exep.Start();
            exep.WaitForExit();//关键，等待外部程序退出后才能往下执行
        }
    }
}
