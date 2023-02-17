using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

#region Example1

//var capture = ScreenCapture.CaptureWindow(new IntPtr(1920));

//BitmapSaver.Save(capture);

#endregion

#region Example2

Image img = ScreenCapture.CaptureDesktop();

img.Save("Test.png");
#endregion

class BitmapSaver
{
    public static int i = 1;

    public static void Save(Bitmap bitmap)
    {
        using FileStream fs = new($"Image{i.ToString()}.png", FileMode.OpenOrCreate);
        bitmap.Save(fs, format: ImageFormat.Png);
        i++;
    }

}

public class ScreenCapture
{
    [DllImport("user32.dll")]
    private static extern IntPtr GetForegroundWindow();

    [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
    public static extern IntPtr GetDesktopWindow();

    [StructLayout(LayoutKind.Sequential)]
    private struct Rect
    {
        public int Left;
        public int Top;
        public int Right;
        public int Bottom;
    }

    [DllImport("user32.dll")]
    private static extern IntPtr GetWindowRect(IntPtr hWnd, ref Rect rect);

    public static Image CaptureDesktop()
    {
        return CaptureWindow(GetDesktopWindow());
    }

    public static Bitmap CaptureActiveWindow()
    {
        return CaptureWindow(GetForegroundWindow());
    }

    public static Bitmap CaptureWindow(IntPtr handle)
    {
        var rect = new Rect();
        GetWindowRect(handle, ref rect);
        var bounds = new Rectangle(rect.Left, rect.Top, rect.Right - rect.Left, rect.Bottom - rect.Top);
        var result = new Bitmap(bounds.Width, bounds.Height);

        using (var graphics = Graphics.FromImage(result))
        {
            graphics.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
        }

        return result;
    }
}
