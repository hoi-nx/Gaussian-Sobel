using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Gaussian_SobelBlur
{
    public static class GaussianBlur
    {

        public static double[,] createKernel(int lenght, double sigma)
        {
            double[,] kernel = new double[lenght, lenght];
            double kernelSum = 0;
            int kernelHatf = (lenght - 1) / 2;
            double distance = 0;
            double constant = 1d / (2 * Math.PI * sigma * sigma);
            for (int y = -kernelHatf; y <= kernelHatf; y++)
            {
                for (int x = -kernelHatf; x <= kernelHatf; x++)
                {
                    distance = ((y * y) + (x * x)) / (2 * sigma * sigma);
                    kernel[y + kernelHatf, x + kernelHatf] = constant * Math.Exp(-distance);
                    kernelSum += kernel[y + kernelHatf, x + kernelHatf];
                }
            }
            for (int y = 0; y < lenght; y++)
            {
                for (int x = 0; x < lenght; x++)
                {
                    kernel[y, x] = kernel[y, x] * 1d / kernelSum;
                }
            }
            Console.WriteLine("ma trận mặt lạ= "+kernel);
            System.Diagnostics.Debug.WriteLine("ma trận mặt lạ= " + kernel);
            return kernel;
        }
        public static Bitmap gaussianBlur(Bitmap srcImage, double[,] kernel)
        {
            int width = srcImage.Width;
            int height = srcImage.Height;
            BitmapData srcData = srcImage.LockBits(new Rectangle(0, 0, width, height),ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            int bytes = srcData.Stride * srcData.Height;
            Console.WriteLine("Stride= " + kernel);
            System.Diagnostics.Debug.WriteLine("Stride= " + srcData.Stride);
            System.Diagnostics.Debug.WriteLine("srcData.Height " + srcData.Height);

            byte[] buffer = new byte[bytes];
            byte[] result = new byte[bytes];
            Marshal.Copy(srcData.Scan0, buffer, 0, bytes);
            srcImage.UnlockBits(srcData);
            int colorChannels = 3;
            double[] rgb = new double[colorChannels];
            int kernelHatf = (kernel.GetLength(0) - 1) / 2;
            System.Diagnostics.Debug.WriteLine("Kernel = " + kernel.GetLength(0));
            int kcenter = 0;
            int kpixel = 0;
            for (int y = kernelHatf; y < height - kernelHatf; y++)
            {
                for (int x = kernelHatf; x < width - kernelHatf; x++)
                {
                    for (int c = 0; c < colorChannels; c++)
                    {
                        rgb[c] = 0.0;
                    }
                    kcenter = y * srcData.Stride + x * 4;
                    for (int fy = -kernelHatf; fy <= kernelHatf; fy++)
                    {
                        for (int fx = -kernelHatf; fx <= kernelHatf; fx++)
                        {
                            kpixel = kcenter + fy * srcData.Stride + fx * 4;
                            for (int c = 0; c < colorChannels; c++)
                            {
                                rgb[c] += (double)(buffer[kpixel + c]) * kernel[fy + kernelHatf, fx + kernelHatf];
                            }
                        }
                    }
                    for (int c = 0; c < colorChannels; c++)
                    {
                        if (rgb[c] > 255)
                        {
                            rgb[c] = 255;
                        }
                        else if (rgb[c] < 0)
                        {
                            rgb[c] = 0;
                        }
                    }
                    for (int c = 0; c < colorChannels; c++)
                    {
                        result[kcenter + c] = (byte)rgb[c];
                    }
                    result[kcenter + 3] = 255;
                }
            }
            Bitmap resultImage = new Bitmap(width, height);
            BitmapData resultData = resultImage.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            Marshal.Copy(result, 0, resultData.Scan0, bytes);
            resultImage.UnlockBits(resultData);
            return resultImage;
        }
    }
}
