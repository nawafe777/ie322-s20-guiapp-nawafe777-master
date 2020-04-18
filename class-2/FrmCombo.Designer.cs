namespace class_2
{
    partial class FrmCombo
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
            this.btnssm1 = new System.Windows.Forms.Button();
            this.btnssm2 = new System.Windows.Forms.Button();
            this.btnrbn = new System.Windows.Forms.Button();
            this.btnrbi = new System.Windows.Forms.Button();
            this.btnrli = new System.Windows.Forms.Button();
            this.btnr2li = new System.Windows.Forms.Button();
            this.CmbDays = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnssm1
            // 
            this.btnssm1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnssm1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnssm1.Location = new System.Drawing.Point(58, 32);
            this.btnssm1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnssm1.Name = "btnssm1";
            this.btnssm1.Size = new System.Drawing.Size(104, 80);
            this.btnssm1.TabIndex = 0;
            this.btnssm1.Text = "Show Selcted Method 1";
            this.btnssm1.UseVisualStyleBackColor = false;
            this.btnssm1.Click += new System.EventHandler(this.btnssm1_Click);
            // 
            // btnssm2
            // 
            this.btnssm2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnssm2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnssm2.Location = new System.Drawing.Point(250, 32);
            this.btnssm2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnssm2.Name = "btnssm2";
            this.btnssm2.Size = new System.Drawing.Size(107, 80);
            this.btnssm2.TabIndex = 1;
            this.btnssm2.Text = "Show Selected Method 2";
            this.btnssm2.UseVisualStyleBackColor = false;
            this.btnssm2.Click += new System.EventHandler(this.btnssm2_Click);
            // 
            // btnrbn
            // 
            this.btnrbn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnrbn.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrbn.Location = new System.Drawing.Point(261, 261);
            this.btnrbn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnrbn.Name = "btnrbn";
            this.btnrbn.Size = new System.Drawing.Size(108, 72);
            this.btnrbn.TabIndex = 2;
            this.btnrbn.Text = "Remove by Name";
            this.btnrbn.UseVisualStyleBackColor = false;
            this.btnrbn.Click += new System.EventHandler(this.btnrbn_Click);
            // 
            // btnrbi
            // 
            this.btnrbi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnrbi.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrbi.Location = new System.Drawing.Point(66, 261);
            this.btnrbi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnrbi.Name = "btnrbi";
            this.btnrbi.Size = new System.Drawing.Size(120, 72);
            this.btnrbi.TabIndex = 3;
            this.btnrbi.Text = "Remove By index";
            this.btnrbi.UseVisualStyleBackColor = false;
            this.btnrbi.Click += new System.EventHandler(this.btnrbi_Click);
            // 
            // btnrli
            // 
            this.btnrli.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnrli.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrli.Location = new System.Drawing.Point(418, 32);
            this.btnrli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnrli.Name = "btnrli";
            this.btnrli.Size = new System.Drawing.Size(122, 80);
            this.btnrli.TabIndex = 4;
            this.btnrli.Text = "Remove last item";
            this.btnrli.UseVisualStyleBackColor = false;
            // 
            // btnr2li
            // 
            this.btnr2li.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnr2li.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnr2li.Location = new System.Drawing.Point(418, 149);
            this.btnr2li.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnr2li.Name = "btnr2li";
            this.btnr2li.Size = new System.Drawing.Size(122, 69);
            this.btnr2li.TabIndex = 5;
            this.btnr2li.Text = "Remove 2nd last item";
            this.btnr2li.UseVisualStyleBackColor = false;
            // 
            // CmbDays
            // 
            this.CmbDays.FormattingEnabled = true;
            this.CmbDays.Location = new System.Drawing.Point(91, 149);
            this.CmbDays.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbDays.Name = "CmbDays";
            this.CmbDays.Size = new System.Drawing.Size(248, 21);
            this.CmbDays.TabIndex = 6;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(418, 261);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 65);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.CmbDays);
            this.Controls.Add(this.btnr2li);
            this.Controls.Add(this.btnrli);
            this.Controls.Add(this.btnrbi);
            this.Controls.Add(this.btnrbn);
            this.Controls.Add(this.btnssm2);
            this.Controls.Add(this.btnssm1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmCombo";
            this.Text = "Form Combo";
            this.Load += new System.EventHandler(this.FrmCombo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnssm1;
        private System.Windows.Forms.Button btnssm2;
        private System.Windows.Forms.Button btnrbn;
        private System.Windows.Forms.Button btnrbi;
        private System.Windows.Forms.Button btnrli;
        private System.Windows.Forms.Button btnr2li;
        private System.Windows.Forms.ComboBox CmbDays;
        private System.Windows.Forms.Button btnBack;
    }
}