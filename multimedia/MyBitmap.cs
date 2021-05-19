using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using AForge.Imaging.Filters;
namespace multimedia
{
    class MyBitmap
    {

        static Bitmap picture;
        static string path;
        public static string GetPath
        {
            set { path = value; }
            get { return path; }
        }
        public static Bitmap Picture
        {
            set { picture = value; }
            get { return picture; }
        }
        public static Bitmap ConvertTo(string x)
        {
            picture = new Bitmap(path);
            Bitmap m = picture;

            switch (x)
            {
                case "red":
                    for (int i = 0; i < m.Width; i++)
                    {
                        for (int j = 0; j < m.Height; j++)
                        {
                            Color c = m.GetPixel(i, j);
                            int a = c.A;
                            int r = c.R;
                            int b = c.B;
                            int g = c.G;
                            m.SetPixel(i, j, Color.FromArgb(a, r, 0, 0));

                        }
                    }
                    return m;
                case "Green":
                    for (int i = 0; i < m.Width; i++)
                    {
                        for (int j = 0; j < m.Height; j++)
                        {
                            Color c = m.GetPixel(i, j);
                            int a = c.A;
                            int r = c.R;
                            int b = c.B;
                            int g = c.G;
                            m.SetPixel(i, j, Color.FromArgb(a, 0, g, 0));

                        }
                    }
                    return m;
                case "blue":
                    for (int i = 0; i < m.Width; i++)
                    {
                        for (int j = 0; j < m.Height; j++)
                        {
                            Color c = m.GetPixel(i, j);
                            int a = c.A;
                            int r = c.R;
                            int b = c.B;
                            int g = c.G;
                            m.SetPixel(i, j, Color.FromArgb(a, 0, 0, b));

                        }
                    }
                    return m;
                case "cyan":
                    for (int i = 0; i < m.Width; i++)
                    {
                        for (int j = 0; j < m.Height; j++)
                        {
                            Color c = m.GetPixel(i, j);
                            int a = c.A;
                            int r = c.R;
                            int b = c.B;
                            int g = c.G;
                            m.SetPixel(i, j, Color.FromArgb(a, 0, b, g));

                        }
                    }
                    return m;
                case "yellow":
                    for (int i = 0; i < m.Width; i++)
                    {
                        for (int j = 0; j < m.Height; j++)
                        {
                            Color c = m.GetPixel(i, j);
                            int a = c.A;
                            int r = c.R;
                            int b = c.B;
                            int g = c.G;
                            m.SetPixel(i, j, Color.FromArgb(a, r, b, 0));

                        }
                    }
                    return m;
                case "magenta":
                    for (int i = 0; i < m.Width; i++)
                    {
                        for (int j = 0; j < m.Height; j++)
                        {
                            Color c = m.GetPixel(i, j);
                            int a = c.A;
                            int r = c.R;
                            int b = c.B;
                            int g = c.G;
                            m.SetPixel(i, j, Color.FromArgb(a, r, 0, g));

                        }
                    }
                    return m;
                case "blackWhite":
                    for (int i = 0; i < m.Width; i++)
                    {
                        for (int j = 0; j < m.Height; j++)
                        {
                            Color c = m.GetPixel(i, j);
                            int a = c.A;
                            int r = c.R;
                            int b = c.B;
                            int g = c.G;
                            int avg = (a + b + g) / 3;
                            if (avg < 200) m.SetPixel(i, j, Color.Black);
                            else { m.SetPixel(i, j, Color.White); };


                        }
                    }
                    return m;
                case "gray":
                    for (int i = 0; i < m.Width; i++)
                    {
                        for (int j = 0; j < m.Height; j++)
                        {
                            Color c = m.GetPixel(i, j);
                            int a = c.A;
                            int r = c.R;
                            int b = c.B;
                            int g = c.G;
                            int avg = (a + b + g) / 3;
                            m.SetPixel(i, j, Color.FromArgb(a, avg, avg, avg));


                        }
                    }
                    return m;
                case "nigatve":
                    for (int i = 0; i < m.Width; i++)
                    {
                        for (int j = 0; j < m.Height; j++)
                        {
                            Color c = m.GetPixel(i, j);
                            int a = c.A;
                            int r = 255 - c.R;
                            int b = 255 - c.B;
                            int g = 255 - c.G;
                            m.SetPixel(i, j, Color.FromArgb(a, r, b, g));

                        }
                    }
                    return m;

                default: return picture;
            }
            /*  public static Bitmap ConvertToGreen()
              {
                  picture = new Bitmap(path);
                  Bitmap m = picture;

              }*/
        }
     
        public static Bitmap ConvertToMirror(string x)
        {
            Bitmap m = new Bitmap(x);
            int width = m.Width;
            int height = m.Height;
            Bitmap mirror = new Bitmap(width * 2, height);
            for (int y = 0; y < height; y++)
            {
                for (int lx = 0, rx = width * 2 - 1; lx < width; lx++, rx--)
                {
                    Color c = m.GetPixel(lx, y);
                    mirror.SetPixel(lx, y, c);
                    mirror.SetPixel(rx, y, c);

                }
            }
            return mirror;
        }
        public static Bitmap ChangeOpacity(Image img, float opacityvalue)
        {
            Bitmap bmp = new Bitmap(img.Width, img.Height); // Determining Width and Height of Source Image
            Graphics graphics = Graphics.FromImage(bmp);
            ColorMatrix colormatrix = new ColorMatrix();
            colormatrix.Matrix33 = opacityvalue;
            ImageAttributes imgAttribute = new ImageAttributes();
            imgAttribute.SetColorMatrix(colormatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            graphics.DrawImage(img, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imgAttribute);
            graphics.Dispose();   // Releasing all resource used by graphics 
            return bmp;
        }
        public static Bitmap Rotate(int rotate,Image img)
        {
            
                Bitmap imge = (Bitmap)img;
                RotateBilinear rb = new RotateBilinear(rotate, true);
                Bitmap imge2 = rb.Apply(imge);
                return imge2;
                
          
            
        }
        public static Image  Flip(Image img)
        {
            Bitmap bmp = new Bitmap(img);
            Bitmap flip = new Bitmap(img.Width, img.Height);
            try
            {
               
                for (int i = 0,fW = bmp.Width - 1; i < bmp.Width; i++,fW--)
                {
                    for (int j = 0/* لقلب الصورة كاملة نضيف برمتر ياخذ نهاية الطول */; j < bmp.Height; j++)
                    {
                        Color c = bmp.GetPixel(i, j);
                        flip.SetPixel(fW, j, c);
                    }
                }
               
            }
            catch (Exception e)
            {
               
            }
            return flip;
        }
    }
 
}
