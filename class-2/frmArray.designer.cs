﻿namespace class_2
{
    partial class frmArray
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
            this.BtnDisplay1DForLoop = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.BtnDisplay1DForEachLoop = new System.Windows.Forms.Button();
            this.BtnDisplay2DForEachLoop = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LstRandom = new System.Windows.Forms.ListBox();
            this.BtnModifyAnArray = new System.Windows.Forms.Button();
            this.BtnModifyAnElement = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnDisplay1DForLoop
            // 
            this.BtnDisplay1DForLoop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnDisplay1DForLoop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDisplay1DForLoop.ForeColor = System.Drawing.Color.Black;
            this.BtnDisplay1DForLoop.Location = new System.Drawing.Point(573, 153);
            this.BtnDisplay1DForLoop.Name = "BtnDisplay1DForLoop";
            this.BtnDisplay1DForLoop.Size = new System.Drawing.Size(92, 76);
            this.BtnDisplay1DForLoop.TabIndex = 0;
            this.BtnDisplay1DForLoop.Text = "Display 1D Array Using For Loop";
            this.BtnDisplay1DForLoop.UseVisualStyleBackColor = false;
            this.BtnDisplay1DForLoop.Click += new System.EventHandler(this.BtnDisplay1DForLoop_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.ForeColor = System.Drawing.Color.Red;
            this.lblDisplay.Location = new System.Drawing.Point(151, 95);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(71, 22);
            this.lblDisplay.TabIndex = 1;
            this.lblDisplay.Text = "Dispaly:";
            // 
            // BtnDisplay1DForEachLoop
            // 
            this.BtnDisplay1DForEachLoop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnDisplay1DForEachLoop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDisplay1DForEachLoop.ForeColor = System.Drawing.Color.Black;
            this.BtnDisplay1DForEachLoop.Location = new System.Drawing.Point(573, 41);
            this.BtnDisplay1DForEachLoop.Name = "BtnDisplay1DForEachLoop";
            this.BtnDisplay1DForEachLoop.Size = new System.Drawing.Size(92, 76);
            this.BtnDisplay1DForEachLoop.TabIndex = 2;
            this.BtnDisplay1DForEachLoop.Text = "Display 1D Array Using For Each Loop";
            this.BtnDisplay1DForEachLoop.UseVisualStyleBackColor = false;
            this.BtnDisplay1DForEachLoop.Click += new System.EventHandler(this.BtnDisplay1DForEachLoop_Click);
            // 
            // BtnDisplay2DForEachLoop
            // 
            this.BtnDisplay2DForEachLoop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnDisplay2DForEachLoop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDisplay2DForEachLoop.ForeColor = System.Drawing.Color.Black;
            this.BtnDisplay2DForEachLoop.Location = new System.Drawing.Point(448, 41);
            this.BtnDisplay2DForEachLoop.Name = "BtnDisplay2DForEachLoop";
            this.BtnDisplay2DForEachLoop.Size = new System.Drawing.Size(92, 76);
            this.BtnDisplay2DForEachLoop.TabIndex = 3;
            this.BtnDisplay2DForEachLoop.Text = "Display 2D Array Using For Loop";
            this.BtnDisplay2DForEachLoop.UseVisualStyleBackColor = false;
            this.BtnDisplay2DForEachLoop.Click += new System.EventHandler(this.BtnDisplay2DForEachLoop_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(573, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 76);
            this.button1.TabIndex = 4;
            this.button1.Text = "Display 2D Array Using For Loop";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(699, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 76);
            this.button2.TabIndex = 5;
            this.button2.Text = "Display A Random Array in ListBox";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LstRandom
            // 
            this.LstRandom.FormattingEnabled = true;
            this.LstRandom.Location = new System.Drawing.Point(25, 72);
            this.LstRandom.Name = "LstRandom";
            this.LstRandom.Size = new System.Drawing.Size(92, 173);
            this.LstRandom.TabIndex = 6;
            // 
            // BtnModifyAnArray
            // 
            this.BtnModifyAnArray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnModifyAnArray.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnModifyAnArray.ForeColor = System.Drawing.Color.Black;
            this.BtnModifyAnArray.Location = new System.Drawing.Point(699, 153);
            this.BtnModifyAnArray.Name = "BtnModifyAnArray";
            this.BtnModifyAnArray.Size = new System.Drawing.Size(92, 76);
            this.BtnModifyAnArray.TabIndex = 7;
            this.BtnModifyAnArray.Text = "Modify An Array";
            this.BtnModifyAnArray.UseVisualStyleBackColor = false;
            this.BtnModifyAnArray.Click += new System.EventHandler(this.BtnModifyAnArray_Click);
            // 
            // BtnModifyAnElement
            // 
            this.BtnModifyAnElement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnModifyAnElement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnModifyAnElement.ForeColor = System.Drawing.Color.Black;
            this.BtnModifyAnElement.Location = new System.Drawing.Point(448, 153);
            this.BtnModifyAnElement.Name = "BtnModifyAnElement";
            this.BtnModifyAnElement.Size = new System.Drawing.Size(92, 76);
            this.BtnModifyAnElement.TabIndex = 8;
            this.BtnModifyAnElement.Text = "Modify An Element";
            this.BtnModifyAnElement.UseVisualStyleBackColor = false;
            this.BtnModifyAnElement.Click += new System.EventHandler(this.BtnModifyAnElement_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnExit.ForeColor = System.Drawing.Color.Black;
            this.BtnExit.Location = new System.Drawing.Point(661, 351);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(130, 76);
            this.BtnExit.TabIndex = 9;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnReset.ForeColor = System.Drawing.Color.Black;
            this.BtnReset.Location = new System.Drawing.Point(403, 352);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(151, 76);
            this.BtnReset.TabIndex = 10;
            this.BtnReset.Text = "Reset All";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // frmArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 439);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnModifyAnElement);
            this.Controls.Add(this.BtnModifyAnArray);
            this.Controls.Add(this.LstRandom);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnDisplay2DForEachLoop);
            this.Controls.Add(this.BtnDisplay1DForEachLoop);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.BtnDisplay1DForLoop);
            this.Name = "frmArray";
            this.Text = "frmArray";
            this.Load += new System.EventHandler(this.frmArray_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDisplay1DForLoop;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button BtnDisplay1DForEachLoop;
        private System.Windows.Forms.Button BtnDisplay2DForEachLoop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox LstRandom;
        private System.Windows.Forms.Button BtnModifyAnArray;
        private System.Windows.Forms.Button BtnModifyAnElement;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnReset;
    }
}