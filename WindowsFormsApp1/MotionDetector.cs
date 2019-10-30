using System;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace WindowsFormsApp1
{
    class MotionDetector
    {

        VideoCapture Capture;
        BackgroundSubtractorMOG2 substractor = new BackgroundSubtractorMOG2(1000, 32, true);

        public MotionDetector(string FileName, bool WebCam = false)
        {
            if (!WebCam) Capture = new VideoCapture(FileName);
            else Capture = new VideoCapture();
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

        public void Restart(int nF=0)
        {
            Capture.SetCaptureProperty(CapProp.PosFrames, nF);
        }

        public Image<Gray, byte> EtalonMethod(Image<Gray,byte> grayImage, Image<Gray, byte> background)
        {
            var grayImg = grayImage.Copy();
            grayImg.Resize(background.Width, background.Height, Emgu.CV.CvEnum.Inter.Linear);
            var diff = background.AbsDiff(grayImage);

            diff.Erode(3);
            diff.Dilate(4);
            diff.SmoothMedian(5);

            return diff;
        }

        private VectorOfVectorOfPoint GetContours(Image<Gray, byte> img, int threshold = 100, int color = 255)
        {
            var binarizedImage = img.ThresholdBinary(new Gray(threshold), new Gray(color));

            var contours = new VectorOfVectorOfPoint();

            CvInvoke.FindContours(binarizedImage, contours, null, Emgu.CV.CvEnum.RetrType.List, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);

            return contours;
        }

        public Image<Bgr, byte> DrawContours(Image<Gray, byte> DiffImage, Image<Bgr, byte> resImage, int func = 0)
        {
            var contours = GetContours(DiffImage);
            for(int i = 0; i < contours.Size; i++)
            {
                if(func == 0)
                { 
                    var points = contours[i].ToArray();
                    resImage.Draw(points, new Bgr(Color.GreenYellow));
                }
                else
                {
                    if(CvInvoke.ContourArea(contours[i], false) > 50)
                    {
                        Rectangle rect = CvInvoke.BoundingRectangle(contours[i]);
                        resImage.Draw(rect, new Bgr(Color.GreenYellow), 1);
                    }
                }
            }

            return resImage;
        }

        /*--- Second Part ---*/

        public Image<Gray, byte> ForegroundMask(Image<Gray, byte> grayImage)
        {
            var foregroundMask = grayImage.CopyBlank();
            substractor.Apply(grayImage, foregroundMask);

            return foregroundMask;
        }

        public Image<Gray, byte> FilterMask(Image<Gray, byte> mask)
        {
            var anchor = new Point(-1, -1);
            var borderValue = new MCvScalar(1);
            // создание структурного элемента заданного размера и формы для морфологических операций
            var kernel = CvInvoke.GetStructuringElement(ElementShape.Ellipse, new Size(3, 3), anchor);
            // заполнение небольших тёмных областей
            var closing = mask.MorphologyEx(MorphOp.Close, kernel, anchor, 1, BorderType.Default,
            borderValue);
            // удаление шумов
            var opening = closing.MorphologyEx(MorphOp.Open, kernel, anchor, 1, BorderType.Default,
            borderValue);
            // расширение для слияния небольших смежных областей
            var dilation = opening.Dilate(7);
            // пороговое преобразование для удаления теней
            var threshold = dilation.ThresholdBinary(new Gray(240), new Gray(255));
        
            return threshold;
        }

        public Image<Bgr, byte> DrowContours2(Image<Gray, byte> filterMask, Image<Bgr,byte> resImage)
        {
            VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
            CvInvoke.FindContours(filterMask, contours, null, RetrType.List, ChainApproxMethod.ChainApproxTc89L1);
            

            for(int i =0; i < contours.Size; i++)
            {
                if(CvInvoke.ContourArea(contours[i]) > 600)
                {
                    Rectangle boundingRect = CvInvoke.BoundingRectangle(contours[i]);
                    resImage.Draw(boundingRect, new Bgr(Color.YellowGreen), 2);
                }
            }

            return resImage;
        }

    }
}
