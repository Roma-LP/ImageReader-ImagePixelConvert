using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace ImageReader
{
    public partial class Canvas : Form
    {
        private Color color = Color.Black;
        private Bitmap bmp;
        private Graphics graphics;
        private Pen pen;
        private bool firstPress = false;
        private bool draw = false;
        private Point p1, p2;

        public Canvas()
        {
            InitializeComponent();

            bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            pen = new Pen(color);
            SetPenWidth(trackBar_width.Value);
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;

            SetBackgroundColor(pictureBox.BackColor);
        }

        Point lastpoint;
        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (draw)
            {
                draw = false;

                using (graphics = Graphics.FromImage(bmp))    // использование using уменьшает количество используемой памяти
                {
                    graphics.DrawLine(pen, p1, p2);
                    p1 = p2;                                                                 // Чтобы линия повторяла курсор мыши                                 
                }
                pictureBox.Image = bmp;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            firstPress = true;
            p1 = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (firstPress)
            {
                p2 = e.Location;
                draw = true;
                pictureBox.Invalidate();
            }
        }

        private void trackBar_width_ValueChanged(object sender, EventArgs e)
        {
            SetPenWidth(trackBar_width.Value);
        }

        private void SetPenWidth(float value)
        {
            pen.Width = value;
        }

        private void SetBackgroundColor(Color color)
        {
            using (graphics = Graphics.FromImage(bmp))    // использование using уменьшает количество используемой памяти
            {
                graphics.Clear(color);
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            SetBackgroundColor(pictureBox.BackColor);
            pictureBox.Image = bmp;
        }

        private void BT_Save_Click(object sender, EventArgs e)
        {
            string fileName2 = @"../../../../Images/canvasImg.png";
            pictureBox.Image.Save(fileName2);
            MessageBox.Show($"Image saved as Images/canvasImg.png","Success");
        }

        private void StartPytonScript()
        {
            //var psi = new ProcessStartInfo();
            //psi.FileName = @"C:\Users\Admin\AppData\Local\Programs\Python\Python311\python.exe";
            //var script = @"../../../../../Test.py";
            //psi.Arguments = $"{script}";

            //psi.UseShellExecute = false;
            //psi.CreateNoWindow = true;
            //psi.RedirectStandardOutput = true;
            //psi.RedirectStandardError = true;

            //var result = "";
            //var errors = "";
            //using (Process process = Process.Start(psi))
            //{
            //    //errors = process.StandardError.ReadToEnd();
            //    //result = process.StandardOutput.ReadToEnd();
            //    using (StreamReader reader = process.StandardOutput)
            //    {
            //        //  string result = reader.ReadToEnd();
            //        //Console.Write(result);
            //    }
            //}

            ScriptEngine engine = Python.CreateEngine();
            engine.ExecuteFile(@"../../../../../Test.py");
        }

        private void button_startPyton_Click(object sender, EventArgs e)
        {
            StartPytonScript();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            firstPress = false;
        }
    }
}
