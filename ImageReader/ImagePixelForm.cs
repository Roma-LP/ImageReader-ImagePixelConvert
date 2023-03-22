using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageReader
{
    public partial class ImagePixelForm : Form
    {
        public ImagePixelForm()
        {
            InitializeComponent();
            UpdateLabel();
        }

        private void buttonImageLoad_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image Files(*.png)|*.png";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            labelImage.Text = Path.GetFileName(openFileDialog.FileName);
            string fileName = openFileDialog.FileName;
            pictureBox.Image = new Bitmap(fileName);
            //MessageBox.Show("Файл открыт","d",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void BT_ToPixels_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(pictureBox.Image);
            ResizePixel(bitmap, TRB_SizePixel.Value);
        }

        private void TRB_SizePixel_ValueChanged(object sender, EventArgs e)
        {
            UpdateLabel();
        }

        private void UpdateLabel()
        {
            label_TRBvalue.Text = TRB_SizePixel.Value.ToString();
        }
        public void ResizePixel(Bitmap bitmap, int pixelSize)
        {
            Bitmap bitmapNew = new Bitmap(bitmap.Width / pixelSize, bitmap.Height / pixelSize);
            for (int y = 0; y < bitmapNew.Height; y++)
            {
                for (int x = 0; x < bitmapNew.Width; x++)
                {
                    int r, g, b, a, count;
                    r = 0; g = 0; b = 0; a = 0; count = 0;
                    for (int y1 = y * pixelSize; y1 < (y + 1) * pixelSize && y1 < bitmap.Height; y1++)
                    {
                        for (int x1 = x * pixelSize; x1 < (x + 1) * pixelSize && x1 < bitmap.Width; x1++)
                        {
                            count++;
                            Color pixel = bitmap.GetPixel(x1, y1);
                            r += pixel.R;
                            g += pixel.G;
                            b += pixel.B;
                            a += pixel.A;
                        }
                    }
                    r /= count;
                    g /= count;
                    b /= count;
                    a /= count;
                    Color colorNew = Color.FromArgb(a, r, g, b);
                    bitmapNew.SetPixel(x, y, colorNew);

                }

            }
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    int xfn = x / pixelSize;
                    int yfn = y / pixelSize;
                    if (xfn >= bitmapNew.Width)
                    {
                        xfn = bitmapNew.Width - 1;
                    }
                    if (yfn >= bitmapNew.Height)
                    {
                        yfn = bitmapNew.Height - 1;
                    }
                    Color colorFromNew = bitmapNew.GetPixel(xfn, yfn);
                    bitmap.SetPixel(x, y, colorFromNew);
                }
            }

            pictureBox.Image = bitmap;
        }

        Point lastpoint;
        private void ImagePixelForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void ImagePixelForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }
    }
}
