using Emgu.CV;
using OpenCvSharp;

try
{
    Console.WriteLine(CvInvoke.BuildInformation);

    using var src = new OpenCvSharp.Mat("lena.png", ImreadModes.Grayscale);
    using var dst = new OpenCvSharp.Mat();

    Cv2.Canny(src, dst, 50, 200);
    using (new Window("src image", src))
    using (new Window("dst image", dst))
    {
        Cv2.WaitKey();
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message + " " + ex.StackTrace);
}