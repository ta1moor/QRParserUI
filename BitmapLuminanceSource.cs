using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;

namespace QRParserUI
{
    public class BitmapLuminanceSource : BaseLuminanceSource
    {
        public BitmapLuminanceSource(Bitmap bitmap) : base(bitmap.Width, bitmap.Height)
        {
            var width = bitmap.Width;
            var height = bitmap.Height;
            var pixels = new int[width * height];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color color = bitmap.GetPixel(x, y);
                    var luminance = (byte)((color.R + color.R + color.B + color.G + color.G + color.G) / 6);
                    luminances[y * width + x] = luminance;
                }
            }
        }

        protected BitmapLuminanceSource(int width, int height) : base(width, height) { }

        protected override LuminanceSource CreateLuminanceSource(byte[] newLuminances, int width, int height)
        {
            return new BitmapLuminanceSource(width, height) { luminances = newLuminances };
        }
    }

}
