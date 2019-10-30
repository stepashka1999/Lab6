using Emgu.CV;
using Emgu.CV.Structure;
using System;
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
        Image<Gray, byte> background;

        /*--- Params ---*/
        bool Play = false;

        /*--- Functions ---*/
        int Func = 0; 
        /* 
        | 0 - Nothing 
        | 1 - Etalon Method 
        | 2 - Drow Contours 
        | 3 - Drow Rect of contours
        | 4 - Foreground Mask
        | 5 - Filter Mask
        | 6 - Drow Rect 2
        */

        private void GetFirstFrame()
        {
            Detector.Restart(1);

            var tempFrame = new Mat();
            Detector.GetFrame(tempFrame);
            background = tempFrame.ToImage<Gray, byte>();
        }


        private void videoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Load();
        }

        private void Load(bool WebCam = false)
        {
            if (!WebCam)
            {
                var OFD = new OpenFileDialog();

                var result = OFD.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Detector = new MotionDetector(OFD.FileName, WebCam);
                }

            }
            else Detector = new MotionDetector(null, true);
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
                               
                var grayImage = image.Copy().Convert<Gray, byte>();

                if (Play)
                {
                    FirstImageBox.Image = image.Copy().Resize(FirstImageBox.Width, FirstImageBox.Height, Emgu.CV.CvEnum.Inter.Linear);
                }
                        

                switch (Func)
                {
                    case 0:
                        break;
                    case 1:
                        ResultImageBox.Image = Detector.EtalonMethod(grayImage, background).Resize(ResultImageBox.Width, ResultImageBox.Height, Emgu.CV.CvEnum.Inter.Linear);
                        break;
                    case 2:
                        ResultImageBox.Image = Detector.DrawContours(Detector.EtalonMethod(grayImage, background), image.Copy()).Resize(ResultImageBox.Width, ResultImageBox.Height, Emgu.CV.CvEnum.Inter.Linear);
                        break;
                    case 3:
                        ResultImageBox.Image = Detector.DrawContours(Detector.EtalonMethod(grayImage, background), image.Copy(), 2).Resize(ResultImageBox.Width, ResultImageBox.Height, Emgu.CV.CvEnum.Inter.Linear);
                        break;
                    case 4:
                        ResultImageBox.Image = Detector.ForegroundMask(grayImage).Resize(ResultImageBox.Width, ResultImageBox.Height, Emgu.CV.CvEnum.Inter.Linear);
                        break;
                    case 5:
                        ResultImageBox.Image = Detector.FilterMask(Detector.ForegroundMask(grayImage)).Resize(ResultImageBox.Width, ResultImageBox.Height, Emgu.CV.CvEnum.Inter.Linear);
                        break;
                    case 6:
                        ResultImageBox.Image = Detector.DrowContours2(Detector.FilterMask(Detector.ForegroundMask(grayImage)), image).Resize(ResultImageBox.Width, ResultImageBox.Height, Emgu.CV.CvEnum.Inter.Linear);
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
            Play = true;
            Detector.Play();            
        }

        private void Pause_button_Click(object sender, EventArgs e)
        {
            Detector.Pause();
            Play = false;
        }

        private void justDiffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Func = 1;
            GetFirstFrame();
        }

        private void contoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Func = 2;
            GetFirstFrame();
        }

        private void rectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Func = 3;
            GetFirstFrame();
        }

        private void foregroundMaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Func = 4;
        }

        private void filterMaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Func = 5;
        }

        private void rectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Func = 6;
        }

        private void vebCamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Load(true);
        }
    }
}
