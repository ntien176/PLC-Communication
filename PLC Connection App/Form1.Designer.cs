namespace PLC_Connection_App
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
            this.lbInfor = new System.Windows.Forms.Label();
            this.lbConnectionStatus = new System.Windows.Forms.Label();
            this.btnReConnect = new System.Windows.Forms.Button();
            this.lbConnectStt = new System.Windows.Forms.Label();
            this.btnOffDenxanh = new System.Windows.Forms.Button();
            this.btnStar = new System.Windows.Forms.Button();
            this.btnM165 = new System.Windows.Forms.Button();
            this.btnPassTro = new System.Windows.Forms.Button();
            this.btnCuaTruot = new System.Windows.Forms.Button();
            this.btnDoaMa = new System.Windows.Forms.Button();
            this.btnResetX2 = new System.Windows.Forms.Button();
            this.rfidTui = new System.Windows.Forms.Button();
            this.btnDoneXQuang = new System.Windows.Forms.Button();
            this.btnMoXquang = new System.Windows.Forms.Button();
            this.btnDemo = new System.Windows.Forms.Button();
            this.lbDemo = new System.Windows.Forms.Label();
            this.btnDemo2 = new System.Windows.Forms.Button();
            this.btnDemo3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbInfor
            // 
            this.lbInfor.AutoSize = true;
            this.lbInfor.Location = new System.Drawing.Point(12, 9);
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
            this.lbConnectionStatus.Size = new System.Drawing.Size(0, 15);
            this.lbConnectionStatus.TabIndex = 2;
            // 
            // btnReConnect
            // 
            this.btnReConnect.Location = new System.Drawing.Point(12, 403);
            this.btnReConnect.Name = "btnReConnect";
            this.btnReConnect.Size = new System.Drawing.Size(91, 22);
            this.btnReConnect.TabIndex = 3;
            this.btnReConnect.Text = "Reload";
            this.btnReConnect.UseVisualStyleBackColor = true;
            this.btnReConnect.Click += new System.EventHandler(this.btnReConnect_Click);
            // 
            // lbConnectStt
            // 
            this.lbConnectStt.AutoSize = true;
            this.lbConnectStt.Location = new System.Drawing.Point(118, 408);
            this.lbConnectStt.Name = "lbConnectStt";
            this.lbConnectStt.Size = new System.Drawing.Size(35, 13);
            this.lbConnectStt.TabIndex = 5;
            this.lbConnectStt.Text = "label1";
            // 
            // btnOffDenxanh
            // 
            this.btnOffDenxanh.Location = new System.Drawing.Point(12, 31);
            this.btnOffDenxanh.Name = "btnOffDenxanh";
            this.btnOffDenxanh.Size = new System.Drawing.Size(91, 22);
            this.btnOffDenxanh.TabIndex = 6;
            this.btnOffDenxanh.Text = "OffDenXanh";
            this.btnOffDenxanh.UseVisualStyleBackColor = true;
            this.btnOffDenxanh.Click += new System.EventHandler(this.btnOffDenxanh_Click);
            // 
            // btnStar
            // 
            this.btnStar.Location = new System.Drawing.Point(12, 59);
            this.btnStar.Name = "btnStar";
            this.btnStar.Size = new System.Drawing.Size(91, 22);
            this.btnStar.TabIndex = 7;
            this.btnStar.Text = "M32";
            this.btnStar.UseVisualStyleBackColor = true;
            this.btnStar.Click += new System.EventHandler(this.btnStar_Click);
            // 
            // btnM165
            // 
            this.btnM165.Location = new System.Drawing.Point(12, 87);
            this.btnM165.Name = "btnM165";
            this.btnM165.Size = new System.Drawing.Size(91, 22);
            this.btnM165.TabIndex = 8;
            this.btnM165.Text = "XLGac";
            this.btnM165.UseVisualStyleBackColor = true;
            this.btnM165.Click += new System.EventHandler(this.btnM165_Click);
            // 
            // btnPassTro
            // 
            this.btnPassTro.Location = new System.Drawing.Point(12, 115);
            this.btnPassTro.Name = "btnPassTro";
            this.btnPassTro.Size = new System.Drawing.Size(91, 22);
            this.btnPassTro.TabIndex = 9;
            this.btnPassTro.Text = "PassTro";
            this.btnPassTro.UseVisualStyleBackColor = true;
            this.btnPassTro.Click += new System.EventHandler(this.btnPassTro_Click);
            // 
            // btnCuaTruot
            // 
            this.btnCuaTruot.Location = new System.Drawing.Point(12, 171);
            this.btnCuaTruot.Name = "btnCuaTruot";
            this.btnCuaTruot.Size = new System.Drawing.Size(91, 22);
            this.btnCuaTruot.TabIndex = 10;
            this.btnCuaTruot.Text = "XQuang";
            this.btnCuaTruot.UseVisualStyleBackColor = true;
            this.btnCuaTruot.Click += new System.EventHandler(this.btnCuaTruot_Click);
            // 
            // btnDoaMa
            // 
            this.btnDoaMa.Location = new System.Drawing.Point(12, 199);
            this.btnDoaMa.Name = "btnDoaMa";
            this.btnDoaMa.Size = new System.Drawing.Size(91, 22);
            this.btnDoaMa.TabIndex = 11;
            this.btnDoaMa.Text = "CuaDoaMa";
            this.btnDoaMa.UseVisualStyleBackColor = true;
            this.btnDoaMa.Click += new System.EventHandler(this.btnDoaMa_Click);
            // 
            // btnResetX2
            // 
            this.btnResetX2.Location = new System.Drawing.Point(12, 284);
            this.btnResetX2.Name = "btnResetX2";
            this.btnResetX2.Size = new System.Drawing.Size(91, 22);
            this.btnResetX2.TabIndex = 12;
            this.btnResetX2.Text = "ResetX2";
            this.btnResetX2.UseVisualStyleBackColor = true;
            this.btnResetX2.Click += new System.EventHandler(this.btnResetX2_Click);
            // 
            // rfidTui
            // 
            this.rfidTui.Location = new System.Drawing.Point(12, 143);
            this.rfidTui.Name = "rfidTui";
            this.rfidTui.Size = new System.Drawing.Size(91, 22);
            this.rfidTui.TabIndex = 13;
            this.rfidTui.Text = "rf";
            this.rfidTui.UseVisualStyleBackColor = true;
            this.rfidTui.Click += new System.EventHandler(this.rfidTui_Click);
            // 
            // btnDoneXQuang
            // 
            this.btnDoneXQuang.Location = new System.Drawing.Point(12, 228);
            this.btnDoneXQuang.Name = "btnDoneXQuang";
            this.btnDoneXQuang.Size = new System.Drawing.Size(91, 22);
            this.btnDoneXQuang.TabIndex = 14;
            this.btnDoneXQuang.Text = "DoneXQuang";
            this.btnDoneXQuang.UseVisualStyleBackColor = true;
            this.btnDoneXQuang.Click += new System.EventHandler(this.btnDoneXQuang_Click);
            // 
            // btnMoXquang
            // 
            this.btnMoXquang.Location = new System.Drawing.Point(12, 256);
            this.btnMoXquang.Name = "btnMoXquang";
            this.btnMoXquang.Size = new System.Drawing.Size(91, 22);
            this.btnMoXquang.TabIndex = 15;
            this.btnMoXquang.Text = "MoXquang";
            this.btnMoXquang.UseVisualStyleBackColor = true;
            this.btnMoXquang.Click += new System.EventHandler(this.btnMoXquang_Click);
            // 
            // btnDemo
            // 
            this.btnDemo.Location = new System.Drawing.Point(121, 31);
            this.btnDemo.Name = "btnDemo";
            this.btnDemo.Size = new System.Drawing.Size(91, 22);
            this.btnDemo.TabIndex = 16;
            this.btnDemo.Text = "Demo";
            this.btnDemo.UseVisualStyleBackColor = true;
            this.btnDemo.Click += new System.EventHandler(this.btnDemo_Click);
            // 
            // lbDemo
            // 
            this.lbDemo.AutoSize = true;
            this.lbDemo.Location = new System.Drawing.Point(218, 36);
            this.lbDemo.Name = "lbDemo";
            this.lbDemo.Size = new System.Drawing.Size(0, 13);
            this.lbDemo.TabIndex = 17;
            // 
            // btnDemo2
            // 
            this.btnDemo2.Location = new System.Drawing.Point(121, 59);
            this.btnDemo2.Name = "btnDemo2";
            this.btnDemo2.Size = new System.Drawing.Size(91, 22);
            this.btnDemo2.TabIndex = 18;
            this.btnDemo2.Text = "Demo2";
            this.btnDemo2.UseVisualStyleBackColor = true;
            this.btnDemo2.Click += new System.EventHandler(this.btnDemo2_Click);
            // 
            // btnDemo3
            // 
            this.btnDemo3.Location = new System.Drawing.Point(121, 87);
            this.btnDemo3.Name = "btnDemo3";
            this.btnDemo3.Size = new System.Drawing.Size(91, 22);
            this.btnDemo3.TabIndex = 19;
            this.btnDemo3.Text = "Demo3";
            this.btnDemo3.UseVisualStyleBackColor = true;
            this.btnDemo3.Click += new System.EventHandler(this.btnDemo3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDemo3);
            this.Controls.Add(this.btnDemo2);
            this.Controls.Add(this.lbDemo);
            this.Controls.Add(this.btnDemo);
            this.Controls.Add(this.btnMoXquang);
            this.Controls.Add(this.btnDoneXQuang);
            this.Controls.Add(this.rfidTui);
            this.Controls.Add(this.btnResetX2);
            this.Controls.Add(this.btnDoaMa);
            this.Controls.Add(this.btnCuaTruot);
            this.Controls.Add(this.btnPassTro);
            this.Controls.Add(this.btnM165);
            this.Controls.Add(this.btnStar);
            this.Controls.Add(this.btnOffDenxanh);
            this.Controls.Add(this.lbConnectStt);
            this.Controls.Add(this.btnReConnect);
            this.Controls.Add(this.lbConnectionStatus);
            this.Controls.Add(this.lbInfor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbInfor;
        public System.Windows.Forms.Label lbConnectionStatus;
        private System.Windows.Forms.Button btnReConnect;
        public System.Windows.Forms.Label lbConnectStt;
        private System.Windows.Forms.Button btnOffDenxanh;
        private System.Windows.Forms.Button btnStar;
        private System.Windows.Forms.Button btnM165;
        private System.Windows.Forms.Button btnPassTro;
        private System.Windows.Forms.Button btnCuaTruot;
        private System.Windows.Forms.Button btnDoaMa;
        private System.Windows.Forms.Button btnResetX2;
        private System.Windows.Forms.Button rfidTui;
        private System.Windows.Forms.Button btnDoneXQuang;
        private System.Windows.Forms.Button btnMoXquang;
        private System.Windows.Forms.Button btnDemo;
        private System.Windows.Forms.Label lbDemo;
        private System.Windows.Forms.Button btnDemo2;
        private System.Windows.Forms.Button btnDemo3;
    }
}

