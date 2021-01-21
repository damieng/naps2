using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace NAPS2.Scan.Images.Transforms
{
    [Serializable]
    public class GrayscaleTransform : Transform
    {
        public float RedWeighting { get; set; } = 0.3f;
        public float GreenWeighting { get; set; } = 0.59f;
        public float BlueWeighting { get; set; } = 0.11f;

        public override Bitmap Perform(Bitmap bitmap)
        {
            if (bitmap.PixelFormat != PixelFormat.Format24bppRgb && bitmap.PixelFormat != PixelFormat.Format32bppArgb)
            {
                return bitmap;
            }

            var greyScaleBitmap = UnsafeImageOps.ConvertToGrayscale(bitmap, RedWeighting, GreenWeighting, BlueWeighting);
            bitmap.Dispose();

            return greyScaleBitmap;
        }
    }
}
