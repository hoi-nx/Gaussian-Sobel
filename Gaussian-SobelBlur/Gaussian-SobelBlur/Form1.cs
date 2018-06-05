using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace Gaussian_SobelBlur
{
    public partial class Form1 : Form
    {
        private Bitmap originalBitmap = null;
     
        private Bitmap resultBitmap = null;
        public Form1()
        {
            InitializeComponent();
          
        }

        private void btnGaussian_Click(object sender, EventArgs e)
        {
            //StreamReader streamReader = new StreamReader(imgInput.ImageLocation);
            //originalBitmap = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
            //streamReader.Close();
            originalBitmap = new Bitmap(imgInput.Image);
            Console.WriteLine("bitmap intput= "+originalBitmap);
            System.Diagnostics.Debug.WriteLine("bitmap intput= " + originalBitmap);
            try
            {
                int matran = int.Parse(txtMatran.Text);
                double sigma = double.Parse(txtSigma.Text);
                resultBitmap= GaussianBlur.gaussianBlur(originalBitmap, GaussianBlur.createKernel(matran, sigma));
                if (resultBitmap != null)
                {
                    imgOutput.Image = resultBitmap;
                }
            }
            catch { }
          
            
            
     
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select an image file.";
            //Png Images(*.png)|*.png|
            ofd.Filter = "Jpg Images(*.jpg)|*.jpg";
            ofd.Filter += "|Bitmap Images(*.bmp)|*.bmp";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                
                imgInput.ImageLocation = ofd.FileName;
            }

        }

        private void btnSobel_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(imgInput.Image);
            Bitmap sobel = Sobel.sobelBlur(image);            
            imgOutput.Image = sobel;

            Bitmap imgout = new Bitmap(imgOutput.Image);
            System.Diagnostics.Debug.WriteLine("bmout= " + imgout.Width);
            System.Diagnostics.Debug.WriteLine("bmout= " + imgout.Height);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
