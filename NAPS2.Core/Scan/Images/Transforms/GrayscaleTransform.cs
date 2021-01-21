using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace NAPS2.Scan.Images.Transforms
{
    [Serializable]
    public class GrayscaleTransform : Transform
    {
        public int RedWeighting { get; set; } = 299;
        public int GreenWeighting { get; set; } = 587;
        public int BlueWeighting { get; set; } = 114;

        public override Bitmap Perform(Bitmap bitmap)
        {
            if (bitmap.PixelFormat != PixelFormat.Format24bppRgb && bitmap.PixelFormat != PixelFormat.Format32bppArgb)
            {
                return bitmap;
            }

            var grayscaleBitmap = UnsafeImageOps.ConvertToGrayscale(bitmap, RedWeighting, GreenWeighting, BlueWeighting);
            bitmap.Dispose();

            return grayscaleBitmap;
        }
    }
}
