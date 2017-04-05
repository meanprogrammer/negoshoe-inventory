using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegoShoePH.Common
{
    public static class ImageResizeHelper
    {
        public static byte[] ProcessResizeImage(string path)
        {
            string filenName = Path.GetFileName(path);
            string extensionName = Path.GetExtension(path);

            using (var image = Image.FromFile(path))
            using (var newImage = ScaleImage(image, 500, 500))
            {
                return imageToByteArray(newImage);
            }
        }


        public static byte[] ProcessResizeImage(Stream input)
        {

            using (var image = Image.FromStream(input))
            using (var newImage = ScaleImage(image, 300, 300))
            {
                return imageToByteArray(newImage);
            }
        }

        private static Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);

            using (var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);

            return newImage;
        }

        private static byte[] imageToByteArray(System.Drawing.Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

    }
}
