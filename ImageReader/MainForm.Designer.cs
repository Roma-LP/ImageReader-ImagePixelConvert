namespace ImageReader
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonImageLoad = new System.Windows.Forms.Button();
            this.labelImage = new System.Windows.Forms.Label();
            this.buttonSaveInFile = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonLoadImageFromFile = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.buttonChooseColor = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelFrom = new System.Windows.Forms.Panel();
            this.panelTo = new System.Windows.Forms.Panel();
            this.buttonChangePixels = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(535, 365);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // buttonImageLoad
            // 
            this.buttonImageLoad.Location = new System.Drawing.Point(617, 12);
            this.buttonImageLoad.Name = "buttonImageLoad";
            this.buttonImageLoad.Size = new System.Drawing.Size(171, 41);
            this.buttonImageLoad.TabIndex = 1;
            this.buttonImageLoad.Text = "Load Image";
            this.buttonImageLoad.UseVisualStyleBackColor = true;
            this.buttonImageLoad.Click += new System.EventHandler(this.buttonImageLoad_Click);
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelImage.Location = new System.Drawing.Point(214, 380);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(0, 25);
            this.labelImage.TabIndex = 2;
            // 
            // buttonSaveInFile
            // 
            this.buttonSaveInFile.Location = new System.Drawing.Point(617, 59);
            this.buttonSaveInFile.Name = "buttonSaveInFile";
            this.buttonSaveInFile.Size = new System.Drawing.Size(171, 41);
            this.buttonSaveInFile.TabIndex = 3;
            this.buttonSaveInFile.Text = "Save In File Image";
            this.buttonSaveInFile.UseVisualStyleBackColor = true;
            this.buttonSaveInFile.Click += new System.EventHandler(this.buttonSaveInFile_Click);
            // 
            // buttonLoadImageFromFile
            // 
            this.buttonLoadImageFromFile.Location = new System.Drawing.Point(617, 106);
            this.buttonLoadImageFromFile.Name = "buttonLoadImageFromFile";
            this.buttonLoadImageFromFile.Size = new System.Drawing.Size(171, 41);
            this.buttonLoadImageFromFile.TabIndex = 4;
            this.buttonLoadImageFromFile.Text = "Load Image From File";
            this.buttonLoadImageFromFile.UseVisualStyleBackColor = true;
            this.buttonLoadImageFromFile.Click += new System.EventHandler(this.buttonLoadImageFromFile_Click);
            // 
            // colorDialog
            // 
            this.colorDialog.FullOpen = true;
            this.colorDialog.SolidColorOnly = true;
            // 
            // buttonChooseColor
            // 
            this.buttonChooseColor.Location = new System.Drawing.Point(617, 153);
            this.buttonChooseColor.Name = "buttonChooseColor";
            this.buttonChooseColor.Size = new System.Drawing.Size(171, 41);
            this.buttonChooseColor.TabIndex = 5;
            this.buttonChooseColor.Text = "Choose Color";
            this.buttonChooseColor.UseVisualStyleBackColor = true;
            this.buttonChooseColor.Click += new System.EventHandler(this.buttonChangePixel_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(617, 336);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(171, 41);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panelFrom
            // 
            this.panelFrom.BackColor = System.Drawing.Color.White;
            this.panelFrom.Location = new System.Drawing.Point(617, 200);
            this.panelFrom.Name = "panelFrom";
            this.panelFrom.Size = new System.Drawing.Size(80, 41);
            this.panelFrom.TabIndex = 7;
            // 
            // panelTo
            // 
            this.panelTo.BackColor = System.Drawing.Color.White;
            this.panelTo.Location = new System.Drawing.Point(708, 200);
            this.panelTo.Name = "panelTo";
            this.panelTo.Size = new System.Drawing.Size(80, 41);
            this.panelTo.TabIndex = 8;
            // 
            // buttonChangePixels
            // 
            this.buttonChangePixels.Location = new System.Drawing.Point(617, 247);
            this.buttonChangePixels.Name = "buttonChangePixels";
            this.buttonChangePixels.Size = new System.Drawing.Size(171, 41);
            this.buttonChangePixels.TabIndex = 9;
            this.buttonChangePixels.Text = "Change Pixels";
            this.buttonChangePixels.UseVisualStyleBackColor = true;
            this.buttonChangePixels.Click += new System.EventHandler(this.buttonChangePixels_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 429);
            this.Controls.Add(this.buttonChangePixels);
            this.Controls.Add(this.panelTo);
            this.Controls.Add(this.panelFrom);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonChooseColor);
            this.Controls.Add(this.buttonLoadImageFromFile);
            this.Controls.Add(this.buttonSaveInFile);
            this.Controls.Add(this.labelImage);
            this.Controls.Add(this.buttonImageLoad);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "ImageReader";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog openFileDialog;
        private PictureBox pictureBox;
        private Button buttonImageLoad;
        private Label labelImage;
        private Button buttonSaveInFile;
        private SaveFileDialog saveFileDialog;
        private Button buttonLoadImageFromFile;
        private ColorDialog colorDialog;
        private Button buttonChooseColor;
        private Button buttonExit;
        private Panel panelFrom;
        private Panel panelTo;
        private Button buttonChangePixels;
    }
}