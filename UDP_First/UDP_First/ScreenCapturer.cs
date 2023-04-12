using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDP_First
{
    internal class ScreenCapturer
    {
        public static byte[] CaptureScreen()
        {
            try
            {
                Bitmap captureBitmap = new Bitmap(1920, 1080, PixelFormat.Format32bppArgb);
                Rectangle captureRectangle = Screen.AllScreens[0].Bounds;
                Graphics captureGraphics = Graphics.FromImage(captureBitmap);

                captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);

                using (MemoryStream memory = new MemoryStream())
                {
                    captureBitmap.Save(memory, ImageFormat.Png);
                    byte[] bytes = memory.ToArray();
                    return bytes;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
