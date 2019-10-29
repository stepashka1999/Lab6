using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*--- Inticialization ---*/

        MotionDetector Detector;

        /*--- Params ---*/
        bool Play = false;

        /*--- Functions ---*/
        int Func = 0; // | 0 - Nothing | 1 - Etalon Method |

        private void videoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var OFD = new OpenFileDialog();

            var result = OFD.ShowDialog();

            if(result == DialogResult.OK)
            {
                Detector = new MotionDetector(OFD.FileName);
            }

            //Subscribe
            Detector.Sub(ImageBoxUbdater);

            Play_button.Visible = true;
            Pause_button.Visible = true;
        }

        private void ImageBoxUbdater(object sender, EventArgs e)
        {
            Mat frame = new Mat();

            Detector.GetFrame(frame);

            if (frame.Bitmap != null)
            {
                var image = frame.ToImage<Bgr, byte>();
                Image<Gray, byte> grayImage;

                if (Play)
                {
                    FirstImageBox.Image = image.Copy().Resize(FirstImageBox.Width, FirstImageBox.Height, Emgu.CV.CvEnum.Inter.Linear);
                }

                switch (Func)
                {
                    case 0:
                        break;
                    case 1:
                        grayImage = image.Copy().Convert<Gray, byte>();
                        ResultImageBox.Image = Detector.EtalonMethod(grayImage);// need change frame to GrayImage
                        break;
                }
            }
            else//Restart after Video End
            {
                MessageBox.Show("Видео закончилось");
                Detector.Pause();
                Detector.Restart();
            }
        }

        private void Play_button_Click(object sender, EventArgs e)
        {
            Detector.Play();
            Play = true;
        }

        private void Pause_button_Click(object sender, EventArgs e)
        {
            Detector.Pause();
            Play = false;
        }
    }
}
