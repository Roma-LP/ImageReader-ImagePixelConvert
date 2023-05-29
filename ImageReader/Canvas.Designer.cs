namespace ImageReader
{
    partial class Canvas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_startPyton = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_width = new System.Windows.Forms.Label();
            this.trackBar_width = new System.Windows.Forms.TrackBar();
            this.BT_Save = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_startPyton);
            this.panel1.Controls.Add(this.button_clear);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.BT_Save);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(464, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 409);
            this.panel1.TabIndex = 1;
            // 
            // button_startPyton
            // 
            this.button_startPyton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_startPyton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_startPyton.Location = new System.Drawing.Point(3, 211);
            this.button_startPyton.Name = "button_startPyton";
            this.button_startPyton.Size = new System.Drawing.Size(249, 61);
            this.button_startPyton.TabIndex = 5;
            this.button_startPyton.Text = "Start";
            this.button_startPyton.UseVisualStyleBackColor = true;
            this.button_startPyton.Visible = false;
            this.button_startPyton.Click += new System.EventHandler(this.button_startPyton_Click);
            // 
            // button_clear
            // 
            this.button_clear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_clear.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_clear.Location = new System.Drawing.Point(3, 278);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(249, 61);
            this.button_clear.TabIndex = 4;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_width);
            this.panel2.Controls.Add(this.trackBar_width);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 100);
            this.panel2.TabIndex = 3;
            // 
            // label_width
            // 
            this.label_width.AutoSize = true;
            this.label_width.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_width.Location = new System.Drawing.Point(82, 9);
            this.label_width.Name = "label_width";
            this.label_width.Size = new System.Drawing.Size(81, 21);
            this.label_width.TabIndex = 2;
            this.label_width.Text = "Width Pen";
            this.label_width.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar_width
            // 
            this.trackBar_width.LargeChange = 1;
            this.trackBar_width.Location = new System.Drawing.Point(3, 36);
            this.trackBar_width.Maximum = 5;
            this.trackBar_width.Minimum = 2;
            this.trackBar_width.Name = "trackBar_width";
            this.trackBar_width.Size = new System.Drawing.Size(249, 45);
            this.trackBar_width.TabIndex = 1;
            this.trackBar_width.Value = 2;
            this.trackBar_width.ValueChanged += new System.EventHandler(this.trackBar_width_ValueChanged);
            // 
            // BT_Save
            // 
            this.BT_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BT_Save.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BT_Save.Location = new System.Drawing.Point(3, 345);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(249, 61);
            this.BT_Save.TabIndex = 0;
            this.BT_Save.Text = "Save";
            this.BT_Save.UseVisualStyleBackColor = true;
            this.BT_Save.Click += new System.EventHandler(this.BT_Save_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(464, 409);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Canvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(719, 409);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.panel1);
            this.Name = "Canvas";
            this.Text = "Canvas";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Button BT_Save;
        private PictureBox pictureBox;
        private Panel panel2;
        private Label label_width;
        private TrackBar trackBar_width;
        private Button button_clear;
        private SaveFileDialog saveFileDialog;
        private Button button_startPyton;
    }
}