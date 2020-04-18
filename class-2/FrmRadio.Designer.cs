namespace class_2
{
    partial class FrmRadio
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
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RDOBlue2 = new System.Windows.Forms.RadioButton();
            this.RDOGreen2 = new System.Windows.Forms.RadioButton();
            this.RDOYellow2 = new System.Windows.Forms.RadioButton();
            this.RDORed2 = new System.Windows.Forms.RadioButton();
            this.RDORed = new System.Windows.Forms.RadioButton();
            this.RDOYellow = new System.Windows.Forms.RadioButton();
            this.RDOGreen = new System.Windows.Forms.RadioButton();
            this.RDOBlue = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(206, 282);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(135, 29);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(206, 21);
            this.BtnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(132, 25);
            this.BtnReset.TabIndex = 1;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RDOBlue2);
            this.groupBox1.Controls.Add(this.RDOGreen2);
            this.groupBox1.Controls.Add(this.RDOYellow2);
            this.groupBox1.Controls.Add(this.RDORed2);
            this.groupBox1.Location = new System.Drawing.Point(274, 72);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(135, 186);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grouped Radio Buttons";
            // 
            // RDOBlue2
            // 
            this.RDOBlue2.AutoSize = true;
            this.RDOBlue2.Location = new System.Drawing.Point(15, 98);
            this.RDOBlue2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RDOBlue2.Name = "RDOBlue2";
            this.RDOBlue2.Size = new System.Drawing.Size(46, 17);
            this.RDOBlue2.TabIndex = 7;
            this.RDOBlue2.TabStop = true;
            this.RDOBlue2.Text = "Blue";
            this.RDOBlue2.UseVisualStyleBackColor = true;
            this.RDOBlue2.CheckedChanged += new System.EventHandler(this.RDOBlue2_CheckedChanged);
            // 
            // RDOGreen2
            // 
            this.RDOGreen2.AutoSize = true;
            this.RDOGreen2.Location = new System.Drawing.Point(15, 64);
            this.RDOGreen2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RDOGreen2.Name = "RDOGreen2";
            this.RDOGreen2.Size = new System.Drawing.Size(54, 17);
            this.RDOGreen2.TabIndex = 6;
            this.RDOGreen2.TabStop = true;
            this.RDOGreen2.Text = "Green";
            this.RDOGreen2.UseVisualStyleBackColor = true;
            this.RDOGreen2.CheckedChanged += new System.EventHandler(this.RDOGreen2_CheckedChanged);
            // 
            // RDOYellow2
            // 
            this.RDOYellow2.AutoSize = true;
            this.RDOYellow2.Location = new System.Drawing.Point(15, 135);
            this.RDOYellow2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RDOYellow2.Name = "RDOYellow2";
            this.RDOYellow2.Size = new System.Drawing.Size(56, 17);
            this.RDOYellow2.TabIndex = 5;
            this.RDOYellow2.TabStop = true;
            this.RDOYellow2.Text = "Yellow";
            this.RDOYellow2.UseVisualStyleBackColor = true;
            this.RDOYellow2.CheckedChanged += new System.EventHandler(this.RDOYellow2_CheckedChanged);
            // 
            // RDORed2
            // 
            this.RDORed2.AutoSize = true;
            this.RDORed2.Location = new System.Drawing.Point(15, 32);
            this.RDORed2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RDORed2.Name = "RDORed2";
            this.RDORed2.Size = new System.Drawing.Size(45, 17);
            this.RDORed2.TabIndex = 3;
            this.RDORed2.TabStop = true;
            this.RDORed2.Text = "Red";
            this.RDORed2.UseVisualStyleBackColor = true;
            this.RDORed2.CheckedChanged += new System.EventHandler(this.RDORed2_CheckedChanged);
            // 
            // RDORed
            // 
            this.RDORed.AutoSize = true;
            this.RDORed.Location = new System.Drawing.Point(155, 103);
            this.RDORed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RDORed.Name = "RDORed";
            this.RDORed.Size = new System.Drawing.Size(45, 17);
            this.RDORed.TabIndex = 0;
            this.RDORed.TabStop = true;
            this.RDORed.Text = "Red";
            this.RDORed.UseVisualStyleBackColor = true;
            this.RDORed.CheckedChanged += new System.EventHandler(this.RDORed_CheckedChanged);
            // 
            // RDOYellow
            // 
            this.RDOYellow.AutoSize = true;
            this.RDOYellow.Location = new System.Drawing.Point(155, 206);
            this.RDOYellow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RDOYellow.Name = "RDOYellow";
            this.RDOYellow.Size = new System.Drawing.Size(56, 17);
            this.RDOYellow.TabIndex = 1;
            this.RDOYellow.TabStop = true;
            this.RDOYellow.Text = "Yellow";
            this.RDOYellow.UseVisualStyleBackColor = true;
            this.RDOYellow.CheckedChanged += new System.EventHandler(this.RDOYellow_CheckedChanged);
            // 
            // RDOGreen
            // 
            this.RDOGreen.AutoSize = true;
            this.RDOGreen.Location = new System.Drawing.Point(155, 136);
            this.RDOGreen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RDOGreen.Name = "RDOGreen";
            this.RDOGreen.Size = new System.Drawing.Size(54, 17);
            this.RDOGreen.TabIndex = 2;
            this.RDOGreen.TabStop = true;
            this.RDOGreen.Text = "Green";
            this.RDOGreen.UseVisualStyleBackColor = true;
            this.RDOGreen.CheckedChanged += new System.EventHandler(this.RDOGreen_CheckedChanged);
            // 
            // RDOBlue
            // 
            this.RDOBlue.AutoSize = true;
            this.RDOBlue.Location = new System.Drawing.Point(155, 170);
            this.RDOBlue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RDOBlue.Name = "RDOBlue";
            this.RDOBlue.Size = new System.Drawing.Size(46, 17);
            this.RDOBlue.TabIndex = 4;
            this.RDOBlue.TabStop = true;
            this.RDOBlue.Text = "Blue";
            this.RDOBlue.UseVisualStyleBackColor = true;
            this.RDOBlue.CheckedChanged += new System.EventHandler(this.RDOBlue_CheckedChanged);
            // 
            // FrmRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 366);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.RDOBlue);
            this.Controls.Add(this.RDORed);
            this.Controls.Add(this.RDOGreen);
            this.Controls.Add(this.RDOYellow);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmRadio";
            this.Text = "Radio Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RDOBlue2;
        private System.Windows.Forms.RadioButton RDOGreen2;
        private System.Windows.Forms.RadioButton RDOYellow2;
        private System.Windows.Forms.RadioButton RDORed2;
        private System.Windows.Forms.RadioButton RDORed;
        private System.Windows.Forms.RadioButton RDOYellow;
        private System.Windows.Forms.RadioButton RDOGreen;
        private System.Windows.Forms.RadioButton RDOBlue;
    }
}