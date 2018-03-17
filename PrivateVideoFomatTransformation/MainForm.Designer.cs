namespace PrivateVideoFomatTransformation
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTransformation = new System.Windows.Forms.Button();
            this.tbPrivateFFMPEG = new System.Windows.Forms.TextBox();
            this.btnPrivateFFMPEG = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPrivateFomatVideoFolder = new System.Windows.Forms.TextBox();
            this.tbOutputFolder = new System.Windows.Forms.TextBox();
            this.btnPrivateFormatVideoFolder = new System.Windows.Forms.Button();
            this.btnOutputFolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.tbThreadNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTransformation
            // 
            this.btnTransformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTransformation.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTransformation.Location = new System.Drawing.Point(582, 218);
            this.btnTransformation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTransformation.Name = "btnTransformation";
            this.btnTransformation.Size = new System.Drawing.Size(75, 192);
            this.btnTransformation.TabIndex = 0;
            this.btnTransformation.Text = "转换";
            this.btnTransformation.UseVisualStyleBackColor = true;
            this.btnTransformation.Click += new System.EventHandler(this.btnTransformation_Click);
            // 
            // tbPrivateFFMPEG
            // 
            this.tbPrivateFFMPEG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPrivateFFMPEG.Location = new System.Drawing.Point(12, 41);
            this.tbPrivateFFMPEG.Name = "tbPrivateFFMPEG";
            this.tbPrivateFFMPEG.ReadOnly = true;
            this.tbPrivateFFMPEG.Size = new System.Drawing.Size(564, 23);
            this.tbPrivateFFMPEG.TabIndex = 1;
            // 
            // btnPrivateFFMPEG
            // 
            this.btnPrivateFFMPEG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrivateFFMPEG.Location = new System.Drawing.Point(582, 41);
            this.btnPrivateFFMPEG.Name = "btnPrivateFFMPEG";
            this.btnPrivateFFMPEG.Size = new System.Drawing.Size(75, 23);
            this.btnPrivateFFMPEG.TabIndex = 2;
            this.btnPrivateFFMPEG.Text = "选择";
            this.btnPrivateFFMPEG.UseVisualStyleBackColor = true;
            this.btnPrivateFFMPEG.Click += new System.EventHandler(this.btnPrivateFFMPEG_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "私有格式对应FFMPEG程序";
            // 
            // tbPrivateFomatVideoFolder
            // 
            this.tbPrivateFomatVideoFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPrivateFomatVideoFolder.Location = new System.Drawing.Point(12, 97);
            this.tbPrivateFomatVideoFolder.Name = "tbPrivateFomatVideoFolder";
            this.tbPrivateFomatVideoFolder.ReadOnly = true;
            this.tbPrivateFomatVideoFolder.Size = new System.Drawing.Size(564, 23);
            this.tbPrivateFomatVideoFolder.TabIndex = 4;
            // 
            // tbOutputFolder
            // 
            this.tbOutputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOutputFolder.Location = new System.Drawing.Point(12, 152);
            this.tbOutputFolder.Name = "tbOutputFolder";
            this.tbOutputFolder.Size = new System.Drawing.Size(564, 23);
            this.tbOutputFolder.TabIndex = 5;
            // 
            // btnPrivateFormatVideoFolder
            // 
            this.btnPrivateFormatVideoFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrivateFormatVideoFolder.Location = new System.Drawing.Point(582, 97);
            this.btnPrivateFormatVideoFolder.Name = "btnPrivateFormatVideoFolder";
            this.btnPrivateFormatVideoFolder.Size = new System.Drawing.Size(75, 23);
            this.btnPrivateFormatVideoFolder.TabIndex = 6;
            this.btnPrivateFormatVideoFolder.Text = "选择";
            this.btnPrivateFormatVideoFolder.UseVisualStyleBackColor = true;
            this.btnPrivateFormatVideoFolder.Click += new System.EventHandler(this.btnPrivateFormatVideoFolder_Click);
            // 
            // btnOutputFolder
            // 
            this.btnOutputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOutputFolder.Location = new System.Drawing.Point(582, 152);
            this.btnOutputFolder.Name = "btnOutputFolder";
            this.btnOutputFolder.Size = new System.Drawing.Size(75, 23);
            this.btnOutputFolder.TabIndex = 7;
            this.btnOutputFolder.Text = "选择";
            this.btnOutputFolder.UseVisualStyleBackColor = true;
            this.btnOutputFolder.Click += new System.EventHandler(this.btnOutputFolder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "私有格式视频所在文件夹";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "输出文件夹";
            // 
            // tbMessage
            // 
            this.tbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMessage.Location = new System.Drawing.Point(12, 218);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.ReadOnly = true;
            this.tbMessage.Size = new System.Drawing.Size(564, 193);
            this.tbMessage.TabIndex = 10;
            // 
            // tbThreadNumber
            // 
            this.tbThreadNumber.Location = new System.Drawing.Point(12, 185);
            this.tbThreadNumber.Name = "tbThreadNumber";
            this.tbThreadNumber.Size = new System.Drawing.Size(68, 23);
            this.tbThreadNumber.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "线程数";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 423);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbThreadNumber);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOutputFolder);
            this.Controls.Add(this.btnPrivateFormatVideoFolder);
            this.Controls.Add(this.tbOutputFolder);
            this.Controls.Add(this.tbPrivateFomatVideoFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrivateFFMPEG);
            this.Controls.Add(this.tbPrivateFFMPEG);
            this.Controls.Add(this.btnTransformation);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "私有格式视频转换";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTransformation;
        private System.Windows.Forms.TextBox tbPrivateFFMPEG;
        private System.Windows.Forms.Button btnPrivateFFMPEG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPrivateFomatVideoFolder;
        private System.Windows.Forms.TextBox tbOutputFolder;
        private System.Windows.Forms.Button btnPrivateFormatVideoFolder;
        private System.Windows.Forms.Button btnOutputFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.TextBox tbThreadNumber;
        private System.Windows.Forms.Label label4;
    }
}

