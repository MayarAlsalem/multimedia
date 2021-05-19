using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace multimedia
{
    class MyImage
    {
        public static Image Write(Image img,string text)
        {
            Bitmap writeimge = new Bitmap(img);
            Font f = new Font("SitkaSmall", 25, FontStyle.Bold, GraphicsUnit.Pixel);
            Graphics graphics = Graphics.FromImage(writeimge);
            graphics.DrawString(text, f, Brushes.Purple, new Point(0, 0));
            return writeimge;
        }
        public static Image Write(Image img, string text,int point1,int point2)
        {
            Bitmap writeimge = new Bitmap(img);
            Font f = new Font("SitkaSmall", 25, FontStyle.Bold, GraphicsUnit.Pixel);
            Graphics graphics = Graphics.FromImage(writeimge);
            graphics.DrawString(text, f, Brushes.Purple, new Point(point1, point2));
            return writeimge;
        }
    }
}
