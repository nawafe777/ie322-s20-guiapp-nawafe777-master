namespace class_2
{
    partial class FrmRandom
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
            this.btngrn = new System.Windows.Forms.Button();
            this.btngeneraterandom = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btngrn
            // 
            this.btngrn.Location = new System.Drawing.Point(164, 10);
            this.btngrn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btngrn.Name = "btngrn";
            this.btngrn.Size = new System.Drawing.Size(278, 52);
            this.btngrn.TabIndex = 0;
            this.btngrn.Text = "Generate Random Color";
            this.btngrn.UseVisualStyleBackColor = true;
            // 
            // btngeneraterandom
            // 
            this.btngeneraterandom.Location = new System.Drawing.Point(104, 205);
            this.btngeneraterandom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btngeneraterandom.Name = "btngeneraterandom";
            this.btngeneraterandom.Size = new System.Drawing.Size(122, 63);
            this.btngeneraterandom.TabIndex = 1;
            this.btngeneraterandom.Text = "generate random";
            this.btngeneraterandom.UseVisualStyleBackColor = true;
            this.btngeneraterandom.Click += new System.EventHandler(this.btngeneraterandom_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(431, 206);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 62);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FrmRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btngeneraterandom);
            this.Controls.Add(this.btngrn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmRandom";
            this.Text = "Form Random";
            this.Load += new System.EventHandler(this.FrmRandom_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btngrn;
        private System.Windows.Forms.Button btngeneraterandom;
        private System.Windows.Forms.Button button3;
    }
}