namespace class_2
{
    partial class Frmpick01
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
            this.BtnLoadimg = new System.Windows.Forms.Button();
            this.Btnre = new System.Windows.Forms.Button();
            this.Pictry = new System.Windows.Forms.PictureBox();
            this.BtnimagefResource = new System.Windows.Forms.Button();
            this.Pictry1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pictry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pictry1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLoadimg
            // 
            this.BtnLoadimg.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnLoadimg.Location = new System.Drawing.Point(64, 43);
            this.BtnLoadimg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnLoadimg.Name = "BtnLoadimg";
            this.BtnLoadimg.Size = new System.Drawing.Size(175, 48);
            this.BtnLoadimg.TabIndex = 0;
            this.BtnLoadimg.Text = "LoadImage";
            this.BtnLoadimg.UseVisualStyleBackColor = false;
            this.BtnLoadimg.Click += new System.EventHandler(this.BtnLoadimg_Click);
            // 
            // Btnre
            // 
            this.Btnre.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btnre.Location = new System.Drawing.Point(25, 319);
            this.Btnre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btnre.Name = "Btnre";
            this.Btnre.Size = new System.Drawing.Size(90, 36);
            this.Btnre.TabIndex = 2;
            this.Btnre.Text = "Reset";
            this.Btnre.UseVisualStyleBackColor = false;
            // 
            // Pictry
            // 
            this.Pictry.Location = new System.Drawing.Point(9, 117);
            this.Pictry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pictry.Name = "Pictry";
            this.Pictry.Size = new System.Drawing.Size(252, 163);
            this.Pictry.TabIndex = 3;
            this.Pictry.TabStop = false;
            // 
            // BtnimagefResource
            // 
            this.BtnimagefResource.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnimagefResource.Location = new System.Drawing.Point(338, 43);
            this.BtnimagefResource.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnimagefResource.Name = "BtnimagefResource";
            this.BtnimagefResource.Size = new System.Drawing.Size(174, 48);
            this.BtnimagefResource.TabIndex = 4;
            this.BtnimagefResource.Text = "IMage form resource";
            this.BtnimagefResource.UseVisualStyleBackColor = false;
            this.BtnimagefResource.Click += new System.EventHandler(this.BtnimagefResource_Click);
            // 
            // Pictry1
            // 
            this.Pictry1.Location = new System.Drawing.Point(292, 117);
            this.Pictry1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pictry1.Name = "Pictry1";
            this.Pictry1.Size = new System.Drawing.Size(252, 163);
            this.Pictry1.TabIndex = 5;
            this.Pictry1.TabStop = false;
            // 
            // Frmpick01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.Pictry1);
            this.Controls.Add(this.BtnimagefResource);
            this.Controls.Add(this.Pictry);
            this.Controls.Add(this.Btnre);
            this.Controls.Add(this.BtnLoadimg);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frmpick01";
            this.Text = "Image";
            this.Load += new System.EventHandler(this.Frmpick01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pictry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pictry1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLoadimg;
        private System.Windows.Forms.Button Btnre;
        private System.Windows.Forms.PictureBox Pictry;
        private System.Windows.Forms.Button BtnimagefResource;
        private System.Windows.Forms.PictureBox Pictry1;
    }
}