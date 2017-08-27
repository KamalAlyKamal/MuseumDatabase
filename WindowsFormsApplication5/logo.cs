using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class logo : Form
    {

        int timeLeft;
        WMPLib.WindowsMediaPlayer Player;
        public logo()
        {
            InitializeComponent();
        }
        private void PlayFile(String url)
        {
            Player = new WMPLib.WindowsMediaPlayer();
            // Player.PlayStateChange +=
            //    new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(Player_PlayStateChange);
            Player.MediaError +=
                new WMPLib._WMPOCXEvents_MediaErrorEventHandler(Player_MediaError);
            Player.URL = url;
            Player.controls.play();
        }
        // private void Player_PlayStateChange(int NewState)
        // {
        //     if ((WMPLib.WMPPlayState)NewState == WMPLib.WMPPlayState.wmppsStopped)
        //     {
        //        this.Close();
        //     }
        // }
        private void Player_MediaError(object pMediaObject)
        {
            MessageBox.Show("Cannot play media file.");
            this.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
            }
            else
            {
                timer1.Stop();
                Player.close();
                new Welcome().Show();
                this.Hide();
            }
        }

        private void logo_Load_1(object sender, EventArgs e)
        {
            timeLeft = 4;
            timer1.Start();
            PlayFile(@"c:\myaudio.wma");
        }
    }
}
