namespace class_2
{
    partial class Frmcheck
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChkBrownie = new System.Windows.Forms.CheckBox();
            this.ChkDount = new System.Windows.Forms.CheckBox();
            this.ChkCoffee = new System.Windows.Forms.CheckBox();
            this.btnback = new System.Windows.Forms.Button();
            this.BtnShow = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChkBrownie);
            this.groupBox1.Controls.Add(this.ChkDount);
            this.groupBox1.Controls.Add(this.ChkCoffee);
            this.groupBox1.Location = new System.Drawing.Point(138, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(276, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your Choice";
            // 
            // ChkBrownie
            // 
            this.ChkBrownie.AutoSize = true;
            this.ChkBrownie.Location = new System.Drawing.Point(33, 90);
            this.ChkBrownie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChkBrownie.Name = "ChkBrownie";
            this.ChkBrownie.Size = new System.Drawing.Size(64, 17);
            this.ChkBrownie.TabIndex = 2;
            this.ChkBrownie.Text = "Brownie";
            this.ChkBrownie.UseVisualStyleBackColor = true;
            // 
            // ChkDount
            // 
            this.ChkDount.AutoSize = true;
            this.ChkDount.Location = new System.Drawing.Point(33, 56);
            this.ChkDount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChkDount.Name = "ChkDount";
            this.ChkDount.Size = new System.Drawing.Size(55, 17);
            this.ChkDount.TabIndex = 1;
            this.ChkDount.Text = "Donut";
            this.ChkDount.UseVisualStyleBackColor = true;
            // 
            // ChkCoffee
            // 
            this.ChkCoffee.AutoSize = true;
            this.ChkCoffee.Location = new System.Drawing.Point(33, 25);
            this.ChkCoffee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChkCoffee.Name = "ChkCoffee";
            this.ChkCoffee.Size = new System.Drawing.Size(57, 17);
            this.ChkCoffee.TabIndex = 0;
            this.ChkCoffee.Text = "Coffee";
            this.ChkCoffee.UseVisualStyleBackColor = true;
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(337, 252);
            this.btnback.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(77, 43);
            this.btnback.TabIndex = 1;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // BtnShow
            // 
            this.BtnShow.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShow.Location = new System.Drawing.Point(138, 252);
            this.BtnShow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(77, 43);
            this.BtnShow.TabIndex = 2;
            this.BtnShow.Text = "Show";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // Frmcheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.BtnShow);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frmcheck";
            this.Text = "Frmcheck";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ChkBrownie;
        private System.Windows.Forms.CheckBox ChkDount;
        private System.Windows.Forms.CheckBox ChkCoffee;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button BtnShow;
    }
}