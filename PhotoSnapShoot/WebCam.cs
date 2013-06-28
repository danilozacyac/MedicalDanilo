using System.Windows.Controls;
using WebCam_Capture;

namespace PhotoSnapShoot
{
    class WebCam
    {
        private WebCamCapture webCam;
        private Image frameImage;
        private readonly int frameNumber = 30;

        public void InitializeWebCam(ref Image imageControl)
        {
            webCam = new WebCamCapture();
            webCam.FrameNumber = ((ulong)(0ul));
            webCam.TimeToCapture_milliseconds = frameNumber;
            webCam.ImageCaptured += new WebCamCapture.WebCamEventHandler(WebCam_ImageCaptured);
            frameImage = imageControl;
        }

        void WebCam_ImageCaptured(object source, WebcamEventArgs e)
        {
            frameImage.Source = Helper.LoadBitmap((System.Drawing.Bitmap)e.WebCamImage);
        }

        public void Start()
        {
            webCam.TimeToCapture_milliseconds = frameNumber;
            webCam.Start(0);
        }

        public void Stop()
        {
            webCam.Stop();
        }

        public void Continue()
        {
            //change the capture time frame
            webCam.TimeToCapture_milliseconds = frameNumber;

            // resume the video capture from the stop
            webCam.Start(this.webCam.FrameNumber);
        }

        public void ResolutionSettings()
        {
            webCam.Config();
        }

        public void AdvanceSettings()
        {
            webCam.Config2();
        }
    }
}
