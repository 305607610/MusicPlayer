namespace MusicPlayer
{
    partial class MusicPlayer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayer));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lalMusicName = new System.Windows.Forms.Label();
            this.btnMusicAdd = new System.Windows.Forms.Button();
            this.trackBarMusic = new System.Windows.Forms.TrackBar();
            this.listBoxMusic = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPalyer = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnafter = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMusic)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Controls.Add(this.lalMusicName, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnMusicAdd, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.trackBarMusic, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.listBoxMusic, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.axWindowsMediaPlayer1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(360, 587);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint);
            // 
            // lalMusicName
            // 
            this.lalMusicName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lalMusicName.AutoSize = true;
            this.lalMusicName.Location = new System.Drawing.Point(113, 26);
            this.lalMusicName.Margin = new System.Windows.Forms.Padding(1);
            this.lalMusicName.Name = "lalMusicName";
            this.lalMusicName.Size = new System.Drawing.Size(71, 12);
            this.lalMusicName.TabIndex = 0;
            this.lalMusicName.Text = "MusicPlayer";
            // 
            // btnMusicAdd
            // 
            this.btnMusicAdd.BackColor = System.Drawing.Color.LightGreen;
            this.btnMusicAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMusicAdd.Location = new System.Drawing.Point(13, 58);
            this.btnMusicAdd.Name = "btnMusicAdd";
            this.btnMusicAdd.Size = new System.Drawing.Size(96, 39);
            this.btnMusicAdd.TabIndex = 1;
            this.btnMusicAdd.Text = "添加歌曲";
            this.btnMusicAdd.UseVisualStyleBackColor = false;
            this.btnMusicAdd.Click += new System.EventHandler(this.BtnMusicAdd_Click);
            // 
            // trackBarMusic
            // 
            this.trackBarMusic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarMusic.Location = new System.Drawing.Point(115, 58);
            this.trackBarMusic.Maximum = 1000;
            this.trackBarMusic.Name = "trackBarMusic";
            this.trackBarMusic.Size = new System.Drawing.Size(232, 39);
            this.trackBarMusic.TabIndex = 2;
            this.trackBarMusic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TrackBarMusic_MouseDown);
            this.trackBarMusic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TrackBarMusic_MouseUp);
            // 
            // listBoxMusic
            // 
            this.listBoxMusic.BackColor = System.Drawing.Color.Plum;
            this.tableLayoutPanel1.SetColumnSpan(this.listBoxMusic, 2);
            this.listBoxMusic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxMusic.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBoxMusic.FormattingEnabled = true;
            this.listBoxMusic.ItemHeight = 16;
            this.listBoxMusic.Location = new System.Drawing.Point(13, 103);
            this.listBoxMusic.Name = "listBoxMusic";
            this.listBoxMusic.Size = new System.Drawing.Size(334, 424);
            this.listBoxMusic.TabIndex = 3;
            this.listBoxMusic.SelectedIndexChanged += new System.EventHandler(this.ListBoxMusic_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnPalyer, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnPause, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnStop, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnafter, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnnext, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(13, 533);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(334, 39);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // btnPalyer
            // 
            this.btnPalyer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPalyer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPalyer.Location = new System.Drawing.Point(3, 3);
            this.btnPalyer.Name = "btnPalyer";
            this.btnPalyer.Size = new System.Drawing.Size(60, 33);
            this.btnPalyer.TabIndex = 0;
            this.btnPalyer.Text = "播放";
            this.btnPalyer.UseVisualStyleBackColor = false;
            this.btnPalyer.Click += new System.EventHandler(this.BtnPalyer_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPause.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPause.Location = new System.Drawing.Point(69, 3);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(60, 33);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "暂停";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStop.Location = new System.Drawing.Point(135, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(60, 33);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // btnafter
            // 
            this.btnafter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnafter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnafter.Location = new System.Drawing.Point(201, 3);
            this.btnafter.Name = "btnafter";
            this.btnafter.Size = new System.Drawing.Size(60, 33);
            this.btnafter.TabIndex = 3;
            this.btnafter.Text = "上一首";
            this.btnafter.UseVisualStyleBackColor = false;
            this.btnafter.Click += new System.EventHandler(this.Btnafter_Click);
            // 
            // btnnext
            // 
            this.btnnext.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnnext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnnext.Location = new System.Drawing.Point(267, 3);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(64, 33);
            this.btnnext.TabIndex = 4;
            this.btnnext.Text = "下一首";
            this.btnnext.UseVisualStyleBackColor = false;
            this.btnnext.Click += new System.EventHandler(this.Btnnext_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(13, 30);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(4, 4);
            this.axWindowsMediaPlayer1.TabIndex = 5;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(364, 591);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(380, 630);
            this.MinimumSize = new System.Drawing.Size(380, 630);
            this.Name = "MusicPlayer";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "音乐播放器";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMusic)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lalMusicName;
        private System.Windows.Forms.Button btnMusicAdd;
        private System.Windows.Forms.TrackBar trackBarMusic;
        private System.Windows.Forms.ListBox listBoxMusic;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnPalyer;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnafter;
        private System.Windows.Forms.Button btnnext;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Timer timer1;
    }
}

