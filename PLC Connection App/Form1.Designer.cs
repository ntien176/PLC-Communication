﻿namespace PLC_Connection_App
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbInfor = new System.Windows.Forms.Label();
            this.lbConnectionStatus = new System.Windows.Forms.Label();
            this.btnReConnect = new System.Windows.Forms.Button();
            this.ucTest1 = new PLC_Connection_App.ucTest();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbInfor
            // 
            this.lbInfor.AutoSize = true;
            this.lbInfor.Location = new System.Drawing.Point(23, 59);
            this.lbInfor.Name = "lbInfor";
            this.lbInfor.Size = new System.Drawing.Size(35, 13);
            this.lbInfor.TabIndex = 1;
            this.lbInfor.Text = "label1";
            // 
            // lbConnectionStatus
            // 
            this.lbConnectionStatus.AutoSize = true;
            this.lbConnectionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConnectionStatus.Location = new System.Drawing.Point(12, 428);
            this.lbConnectionStatus.Name = "lbConnectionStatus";
            this.lbConnectionStatus.Size = new System.Drawing.Size(41, 15);
            this.lbConnectionStatus.TabIndex = 2;
            this.lbConnectionStatus.Text = "label1";
            // 
            // btnReConnect
            // 
            this.btnReConnect.Location = new System.Drawing.Point(26, 144);
            this.btnReConnect.Name = "btnReConnect";
            this.btnReConnect.Size = new System.Drawing.Size(91, 22);
            this.btnReConnect.TabIndex = 3;
            this.btnReConnect.Text = "Reload";
            this.btnReConnect.UseVisualStyleBackColor = true;
            this.btnReConnect.Click += new System.EventHandler(this.btnReConnect_Click);
            // 
            // ucTest1
            // 
            this.ucTest1.Location = new System.Drawing.Point(299, 12);
            this.ucTest1.Name = "ucTest1";
            this.ucTest1.Size = new System.Drawing.Size(150, 150);
            this.ucTest1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ucTest1);
            this.Controls.Add(this.btnReConnect);
            this.Controls.Add(this.lbConnectionStatus);
            this.Controls.Add(this.lbInfor);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbInfor;
        public System.Windows.Forms.Label lbConnectionStatus;
        private System.Windows.Forms.Button btnReConnect;
        private ucTest ucTest1;
    }
}

