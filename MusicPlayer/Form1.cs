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
using WMPLib;

namespace MusicPlayer
{
    public partial class MusicPlayer : Form
    {
        double max, min;

        List<string> urlList = new List<string>();
        public MusicPlayer()
        {
            InitializeComponent();
        }

        private void ListBoxMusic_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SelectedIndex = listBoxMusic.SelectedIndex;
            
            axWindowsMediaPlayer1.URL = urlList[SelectedIndex];
            timer1.Enabled = true;
            lalMusicName.Text = listBoxMusic.SelectedItem.ToString();
        }

        private void BtnMusicAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Title = "请选择音乐文件";
            of.Multiselect = true;
            of.Filter = "(*.mp3)|*.mp3";
            if(of.ShowDialog() == DialogResult.OK)
            {
                string[] nameList = of.FileNames;
                foreach(string url in nameList)
                {
                    //Path.GetFileNameWithoutExtension(url);
                    listBoxMusic.Items.Add(Path.GetFileNameWithoutExtension(url));
                    urlList.Add(url);
                }
            }
        }

        private void BtnPalyer_Click(object sender, EventArgs e)
        {
            int SelectedIndex = listBoxMusic.SelectedIndex;
            if(SelectedIndex < 0)
            {
                SelectedIndex = SelectedIndex < 0 ? 0 : SelectedIndex;

                listBoxMusic.SelectedIndex = SelectedIndex;
                axWindowsMediaPlayer1.URL = urlList[SelectedIndex];
                lalMusicName.Text = listBoxMusic.SelectedItem.ToString();
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            timer1.Enabled = true;
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            timer1.Enabled = false;
        }

        private void Btnafter_Click(object sender, EventArgs e)
        {
            int SelectedIndex = listBoxMusic.SelectedIndex - 1;

            SelectedIndex = SelectedIndex < 0 ? listBoxMusic.Items.Count - 1 : SelectedIndex;
            listBoxMusic.SelectedIndex = SelectedIndex;
            axWindowsMediaPlayer1.URL = urlList[SelectedIndex];
            lalMusicName.Text = listBoxMusic.SelectedItem.ToString();
        }

        private void Btnnext_Click(object sender, EventArgs e)
        {
            int SelectedIndex = listBoxMusic.SelectedIndex + 1;

            SelectedIndex = SelectedIndex == listBoxMusic.Items.Count ? 0 : SelectedIndex;
            listBoxMusic.SelectedIndex = SelectedIndex;
            axWindowsMediaPlayer1.URL = urlList[SelectedIndex];
            lalMusicName.Text = listBoxMusic.SelectedItem.ToString();
        }

        private void TrackBarMusic_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void TrackBarMusic_MouseUp(object sender, MouseEventArgs e)
        {
            double doValue = trackBarMusic.Value;
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = doValue;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            timer1.Enabled = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            max = axWindowsMediaPlayer1.currentMedia.duration;
            min = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;

            trackBarMusic.Maximum = (int)(max);
            trackBarMusic.Value = (int)(min);

            if (axWindowsMediaPlayer1.playState == WMPPlayState.wmppsStopped)
            {
                int SelectedIndex = listBoxMusic.SelectedIndex + 1;
                SelectedIndex = SelectedIndex == listBoxMusic.Items.Count ? 0 : SelectedIndex;

                axWindowsMediaPlayer1.URL = urlList[SelectedIndex];

                listBoxMusic.SelectedIndex = SelectedIndex;
                lalMusicName.Text = listBoxMusic.SelectedItem.ToString();
                trackBarMusic.Value = 0;
                timer1.Enabled = true;

            }
        }
    }
    
}
