

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing;
using OpenCvSharp;
using OpenCvSharp.CPlusPlus;
using OpenCvSharp.Extensions;


namespace TrainInfo
{
    public partial class Main : Form
    {
        
        //VideoFileSource videoFile;

        public Main()
        {
            InitializeComponent();

        }
        VideoCapture video;
        Mat frame = new Mat();
        

        private void Main_Load(object sender, EventArgs e)
        {


           
            try
            {
                video = new VideoCapture(@"home.mp4");
            }
            catch
            {
                timer1.Enabled = false;
            }

            /* while (true)
              {
                  test.Read(frame);
                  if (!frame.Empty())
                  {
                      Cv2.Resize(frame, frame, new Size(frame.Width * 1 / 2, frame.Height * 1 / 2));
                      Cv2.ImShow("test", frame);
                      Cv2.WaitKey(33);
                  }
                  else break;
              }
              frame.Release(); Cv2.DestroyAllWindows(); //Cv2.DestroyWindow("test");*/

        }


        private void button3_Click(object sender, EventArgs e)
        {
            InfoSearch infoSearch = new InfoSearch();
            infoSearch.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArrivalInfo ai = new ArrivalInfo();
            ai.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
           /* video.Read(frame);
            Cv2.Resize(frame, frame, new OpenCvSharp.CPlusPlus.Size(frame.Width * 1 / 2, frame.Height * 1 / 2));

           
           
            pictureBoxIpl1.ImageIpl = frame.ToIplImage();*/

        }//ToIplImage

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            frame.Dispose();
        }
    }
}
