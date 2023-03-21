namespace ImageReader
{
    partial class ImagePixelForm
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonImageLoad = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.labelImage = new System.Windows.Forms.Label();
            this.BT_ToPixels = new System.Windows.Forms.Button();
            this.TRB_SizePixel = new System.Windows.Forms.TrackBar();
            this.label_TRBvalue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRB_SizePixel)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(535, 365);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // buttonImageLoad
            // 
            this.buttonImageLoad.Location = new System.Drawing.Point(617, 12);
            this.buttonImageLoad.Name = "buttonImageLoad";
            this.buttonImageLoad.Size = new System.Drawing.Size(171, 41);
            this.buttonImageLoad.TabIndex = 2;
            this.buttonImageLoad.Text = "Load Image";
            this.buttonImageLoad.UseVisualStyleBackColor = true;
            this.buttonImageLoad.Click += new System.EventHandler(this.buttonImageLoad_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelImage.Location = new System.Drawing.Point(12, 398);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(80, 32);
            this.labelImage.TabIndex = 3;
            this.labelImage.Text = "None";
            // 
            // BT_ToPixels
            // 
            this.BT_ToPixels.Location = new System.Drawing.Point(617, 101);
            this.BT_ToPixels.Name = "BT_ToPixels";
            this.BT_ToPixels.Size = new System.Drawing.Size(171, 41);
            this.BT_ToPixels.TabIndex = 4;
            this.BT_ToPixels.Text = "ConvertToPixels";
            this.BT_ToPixels.UseVisualStyleBackColor = true;
            this.BT_ToPixels.Click += new System.EventHandler(this.BT_ToPixels_Click);
            // 
            // TRB_SizePixel
            // 
            this.TRB_SizePixel.Location = new System.Drawing.Point(732, 148);
            this.TRB_SizePixel.Maximum = 15;
            this.TRB_SizePixel.Minimum = 1;
            this.TRB_SizePixel.Name = "TRB_SizePixel";
            this.TRB_SizePixel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TRB_SizePixel.Size = new System.Drawing.Size(56, 236);
            this.TRB_SizePixel.TabIndex = 5;
            this.TRB_SizePixel.Value = 5;
            this.TRB_SizePixel.ValueChanged += new System.EventHandler(this.TRB_SizePixel_ValueChanged);
            // 
            // label_TRBvalue
            // 
            this.label_TRBvalue.AutoSize = true;
            this.label_TRBvalue.Location = new System.Drawing.Point(732, 387);
            this.label_TRBvalue.Name = "label_TRBvalue";
            this.label_TRBvalue.Size = new System.Drawing.Size(50, 20);
            this.label_TRBvalue.TabIndex = 6;
            this.label_TRBvalue.Text = "label1";
            // 
            // ImagePixelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_TRBvalue);
            this.Controls.Add(this.TRB_SizePixel);
            this.Controls.Add(this.BT_ToPixels);
            this.Controls.Add(this.labelImage);
            this.Controls.Add(this.buttonImageLoad);
            this.Controls.Add(this.pictureBox);
            this.Name = "ImagePixelForm";
            this.Text = "ImagePixelForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRB_SizePixel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox;
        private Button buttonImageLoad;
        private OpenFileDialog openFileDialog;
        private Label labelImage;
        private Button BT_ToPixels;
        private TrackBar TRB_SizePixel;
        private Label label_TRBvalue;
    }
}