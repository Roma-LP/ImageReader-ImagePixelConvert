namespace ImageReader
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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

        private void buttonSaveInFile_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null)
                return;

            Bitmap image = new Bitmap(pictureBox.Image);
            int width = image.Width;
            int height = image.Height;
            ColorManager[,] colorManager = new ColorManager[width, height];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    colorManager[i, j] = new ColorManager(i, j, image.GetPixel(i, j));
                }
            }


            saveFileDialog.Filter = "Text Files(*.txt;)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog.FileName;
            using (StreamWriter writer = new StreamWriter(filename, false))
            {
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        writer.WriteLine($"{i} {j} {colorManager[i, j].A} {colorManager[i, j].R} {colorManager[i, j].G} {colorManager[i, j].B}");
                    }
                }

            }
        }

        private void buttonLoadImageFromFile_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Text Files(*.txt;)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            string fileName = openFileDialog.FileName;
            List<ColorManager> colorManager = new List<ColorManager>();
            int x, y;
            byte R, G, B, A;
            using (StreamReader reader = new StreamReader(fileName, false))
            {
                while (reader.Peek() >= 0)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    Int32.TryParse(values[0], out x);
                    Int32.TryParse(values[1], out y);
                    Byte.TryParse(values[2], out A);
                    Byte.TryParse(values[3], out R);
                    Byte.TryParse(values[4], out G);
                    Byte.TryParse(values[5], out B);

                    colorManager.Add(new ColorManager(x, y, A, R, G, B));
                }
            }

            int width = colorManager[colorManager.Count - 1].X + 1;
            int height = colorManager[colorManager.Count - 1].Y + 1;
            Bitmap bitmap = new Bitmap(width, height);
            for (int i = 0; i < colorManager.Count; i++)
                bitmap.SetPixel(colorManager[i].X, colorManager[i].Y,
                     Color.FromArgb(colorManager[i].A, colorManager[i].R, colorManager[i].G, colorManager[i].B));

            pictureBox.Image = bitmap;
            labelImage.Text = Path.GetFileName(openFileDialog.FileName);
        }

        private void buttonChangePixel_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
                return;
            panelFrom.BackColor = colorDialog.Color;

            if (colorDialog.ShowDialog() == DialogResult.Cancel)
                return;
            panelTo.BackColor = colorDialog.Color;
        }

        Point lastpoint;
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void buttonChangePixels_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null)
                return;

            Bitmap bitmap = new Bitmap(pictureBox.Image);
            int width = pictureBox.Width;
            int height = pictureBox.Height;
            Color from = panelFrom.BackColor;
            Color to = panelTo.BackColor;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (bitmap.GetPixel(i, j) == from)
                        bitmap.SetPixel(i, j, to);
                }
            }
            pictureBox.Image = bitmap;
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (pictureBox.Image == null)
                return;

            using (var bmp = new Bitmap(pictureBox.Image.Width, pictureBox.Image.Height))
            {
                pictureBox.DrawToBitmap(bmp, pictureBox.ClientRectangle);
                var color = bmp.GetPixel(e.X, e.Y);
                var red = color.R;
                var green = color.G;
                var blue = color.B;
                panelFrom.BackColor = Color.FromArgb(red, green, blue);
            }
        }
    }
}