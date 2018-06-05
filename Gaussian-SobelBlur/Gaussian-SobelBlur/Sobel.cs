using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaussian_SobelBlur
{
   public static class Sobel
    {
        public static Bitmap sobelBlur(Bitmap image)
        {
            Bitmap bm = getBitmapImage(image);
            Bitmap buffer = new Bitmap(bm.Width, bm.Height);

            System.Diagnostics.Debug.WriteLine("bm= " + bm.Width);
            System.Diagnostics.Debug.WriteLine("bm= " + bm.Height);
            Color renk;

            int x, y, gradyan;
            int[,] GX = new int[3, 3];
            int[,] GY = new int[3, 3];

            GX[0, 0] = -1; GX[0, 1] = 0; GX[0, 2] = 1;
            GX[1, 0] = -2; GX[1, 1] = 0; GX[1, 2] = 2;
            GX[2, 0] = -1; GX[2, 1] = 0; GX[2, 2] = 1;


            GY[0, 0] = -1; GY[0, 1] = -2; GY[0, 2] = -1;
            GY[1, 0] = 0; GY[1, 1] = 0; GY[1, 2] = 0;
            GY[2, 0] = 1; GY[2, 1] = 2; GY[2, 2] = 1;


            for (int i = 0; i < bm.Height - 2; i++)
            {
                for (int j = 0; j < bm.Width - 2; j++)
                {
                    if (i == 0 || i == bm.Height - 2 || j == 0 || j == bm.Width - 2)
                    {

                        renk = Color.FromArgb(255, 255, 255);
                        buffer.SetPixel(j, i, renk);
                        x = 0;
                        y = 0;
                    }
                    else
                    {
                        x = bm.GetPixel(j - 1, i - 1).R * GX[0, 0] +
                            bm.GetPixel(j, i - 1).R * GX[0, 1] +
                            bm.GetPixel(j + 1, i - 1).R * GX[0, 2] +
                            bm.GetPixel(j - 1, i).R * GX[1, 0] +
                            bm.GetPixel(j, i).R * GX[1, 1] +
                            bm.GetPixel(j + 1, i).R * GX[1, 2] +
                            bm.GetPixel(j - 1, i + 1).R * GX[2, 0] +
                            bm.GetPixel(j, i + 1).R * GX[2, 1] +
                            bm.GetPixel(j + 1, i + 1).R * GX[2, 2];

                        y = bm.GetPixel(j - 1, i - 1).R * GY[0, 0] +
                            bm.GetPixel(j, i - 1).R * GY[0, 1] +
                            bm.GetPixel(j + 1, i - 1).R * GY[0, 2] +
                            bm.GetPixel(j - 1, i).R * GY[1, 0] +
                            bm.GetPixel(j, i).R * GY[1, 1] +
                            bm.GetPixel(j + 1, i).R * GY[1, 2] +
                            bm.GetPixel(j - 1, i + 1).R * GY[2, 0] +
                            bm.GetPixel(j, i + 1).R * GY[2, 1] +
                            bm.GetPixel(j + 1, i + 1).R * GY[2, 2];

                        gradyan = (int)(Math.Abs(x) + Math.Abs(y));
                        if (gradyan < 0)
                        {
                            gradyan = 0;
                        }
                        if (gradyan > 255)
                        {
                            gradyan = 255;
                        }
                        renk = Color.FromArgb(gradyan, gradyan, gradyan);
                        buffer.SetPixel(j, i, renk);

                  

                    }
                }
            }

            return buffer;
        }
        public static Bitmap getBitmapImage(Bitmap image)
        {

            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    int deger = (image.GetPixel(j, i).R + image.GetPixel(j, i).G + image.GetPixel(j, i).B) / 3;

                    Color renk;
                    renk = Color.FromArgb(deger, deger, deger);
                    image.SetPixel(j, i, renk);
                }
            }

            return image;
        }
    }
}
