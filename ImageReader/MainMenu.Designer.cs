namespace ImageReader
{
    partial class MainMenu
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
            this.BT_FirstApp = new System.Windows.Forms.Button();
            this.BT_SecondApp = new System.Windows.Forms.Button();
            this.BT_ThirdApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BT_FirstApp
            // 
            this.BT_FirstApp.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BT_FirstApp.Location = new System.Drawing.Point(10, 9);
            this.BT_FirstApp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_FirstApp.Name = "BT_FirstApp";
            this.BT_FirstApp.Size = new System.Drawing.Size(148, 68);
            this.BT_FirstApp.TabIndex = 0;
            this.BT_FirstApp.Text = "FirstApp";
            this.BT_FirstApp.UseVisualStyleBackColor = true;
            this.BT_FirstApp.Click += new System.EventHandler(this.BT_FirstApp_Click);
            // 
            // BT_SecondApp
            // 
            this.BT_SecondApp.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BT_SecondApp.Location = new System.Drawing.Point(261, 9);
            this.BT_SecondApp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_SecondApp.Name = "BT_SecondApp";
            this.BT_SecondApp.Size = new System.Drawing.Size(148, 68);
            this.BT_SecondApp.TabIndex = 1;
            this.BT_SecondApp.Text = "SecondApp";
            this.BT_SecondApp.UseVisualStyleBackColor = true;
            this.BT_SecondApp.Click += new System.EventHandler(this.BT_SecondApp_Click);
            // 
            // BT_ThirdApp
            // 
            this.BT_ThirdApp.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BT_ThirdApp.Location = new System.Drawing.Point(134, 81);
            this.BT_ThirdApp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_ThirdApp.Name = "BT_ThirdApp";
            this.BT_ThirdApp.Size = new System.Drawing.Size(148, 68);
            this.BT_ThirdApp.TabIndex = 2;
            this.BT_ThirdApp.Text = "ThirdApp";
            this.BT_ThirdApp.UseVisualStyleBackColor = true;
            this.BT_ThirdApp.Click += new System.EventHandler(this.BT_ThirdApp_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 153);
            this.Controls.Add(this.BT_ThirdApp);
            this.Controls.Add(this.BT_SecondApp);
            this.Controls.Add(this.BT_FirstApp);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button BT_FirstApp;
        private Button BT_SecondApp;
        private Button BT_ThirdApp;
    }
}