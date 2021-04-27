using AForge.Video.FFMPEG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainInfo
{
    public partial class Main : Form
    {
        VideoFileSource videoFile;
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrivalInfo ai = new ArrivalInfo();
            ai.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            /*string filePath = @"./home.mp4";
            videoFile = new VideoFileSource(filePath);
*/
            //this.videoSourcePlayer1.VideoSource = videoFile;
            //this.videoSourcePlayer1.Start();
        }
    }
}
