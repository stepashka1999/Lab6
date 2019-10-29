using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;

namespace WindowsFormsApp1
{
    class MotionDetector
    {
        VideoCapture Capture;
        public MotionDetector(string FileName)
        {
            Capture = new VideoCapture(FileName);
        }

        /*--- Play / Pause ---*/

        public void Play()
        {
            Capture.Start();
        }

        public void Pause()
        {
            Capture.Pause();
        }


        /*--- Sub / Unsub ---*/

        public void Sub(EventHandler SomeFunction)
        {
            Capture.ImageGrabbed += SomeFunction;
        }

        public void UnSub(EventHandler SomeFunction)
        {
            Capture.ImageGrabbed -= SomeFunction;
        }

        /*--- GetFrame ---*/
        public void GetFrame(Mat frame)
        {
            Capture.Retrieve(frame);
        }
        
        //Not Working
        public Image<Bgr,byte> QueryFrame()
        {
            return Capture.QueryFrame().ToImage<Bgr,byte>();
        }

        public void Restart()
        {
            Capture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.PosFrames, 0);
        }

        public Image<Gray, byte> EtalonMethod(Image<Gray,byte> grayImage)
        {            
            Capture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.PosFrames, 0);
            var firstFrame = Capture.QueryFrame();

            var background = firstFrame.ToImage<Gray, byte>();

            var diff = background.AbsDiff(grayImage);

            return diff;
        }

    }
}
