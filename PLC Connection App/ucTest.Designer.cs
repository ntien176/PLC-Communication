
namespace PLC_Connection_App
{
    partial class ucTest
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnM82 = new System.Windows.Forms.Button();
            this.lbM82 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnM82
            // 
            this.btnM82.Location = new System.Drawing.Point(21, 115);
            this.btnM82.Name = "btnM82";
            this.btnM82.Size = new System.Drawing.Size(75, 23);
            this.btnM82.TabIndex = 0;
            this.btnM82.Text = "M82";
            this.btnM82.UseVisualStyleBackColor = true;
            this.btnM82.Click += new System.EventHandler(this.btnM82_Click);
            // 
            // lbM82
            // 
            this.lbM82.AutoSize = true;
            this.lbM82.Location = new System.Drawing.Point(18, 86);
            this.lbM82.Name = "lbM82";
            this.lbM82.Size = new System.Drawing.Size(35, 13);
            this.lbM82.TabIndex = 1;
            this.lbM82.Text = "label1";
            // 
            // ucTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbM82);
            this.Controls.Add(this.btnM82);
            this.Name = "ucTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnM82;
        private System.Windows.Forms.Label lbM82;
    }
}
