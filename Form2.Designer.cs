namespace Practica_4
{
    partial class Form2
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
            this.lblerror = new System.Windows.Forms.Label();
            this.lblp = new System.Windows.Forms.Label();
            this.lblpa = new System.Windows.Forms.Label();
            this.btnc = new System.Windows.Forms.Button();
            this.btnr = new System.Windows.Forms.Button();
            this.txtu = new System.Windows.Forms.TextBox();
            this.txtp = new System.Windows.Forms.TextBox();
            this.txtc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblerror.Location = new System.Drawing.Point(27, 62);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(49, 20);
            this.lblerror.TabIndex = 0;
            this.lblerror.Text = "User";
            this.lblerror.Click += new System.EventHandler(this.lblerror_Click);
            // 
            // lblp
            // 
            this.lblp.AutoSize = true;
            this.lblp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblp.Location = new System.Drawing.Point(27, 118);
            this.lblp.Name = "lblp";
            this.lblp.Size = new System.Drawing.Size(91, 20);
            this.lblp.TabIndex = 1;
            this.lblp.Text = "Password";
            // 
            // lblpa
            // 
            this.lblpa.AutoSize = true;
            this.lblpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblpa.Location = new System.Drawing.Point(27, 169);
            this.lblpa.Name = "lblpa";
            this.lblpa.Size = new System.Drawing.Size(163, 20);
            this.lblpa.TabIndex = 2;
            this.lblpa.Text = "Confirm Password";
            // 
            // btnc
            // 
            this.btnc.BackColor = System.Drawing.Color.Salmon;
            this.btnc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnc.Location = new System.Drawing.Point(210, 225);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(75, 23);
            this.btnc.TabIndex = 3;
            this.btnc.Text = "Crear";
            this.btnc.UseVisualStyleBackColor = false;
            this.btnc.Click += new System.EventHandler(this.btnc_Click);
            // 
            // btnr
            // 
            this.btnr.BackColor = System.Drawing.Color.Salmon;
            this.btnr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnr.Location = new System.Drawing.Point(321, 225);
            this.btnr.Name = "btnr";
            this.btnr.Size = new System.Drawing.Size(75, 23);
            this.btnr.TabIndex = 4;
            this.btnr.Text = "Regresar";
            this.btnr.UseVisualStyleBackColor = false;
            this.btnr.Click += new System.EventHandler(this.btnr_Click);
            // 
            // txtu
            // 
            this.txtu.Location = new System.Drawing.Point(185, 62);
            this.txtu.Name = "txtu";
            this.txtu.Size = new System.Drawing.Size(100, 22);
            this.txtu.TabIndex = 5;
            // 
            // txtp
            // 
            this.txtp.Location = new System.Drawing.Point(185, 116);
            this.txtp.Name = "txtp";
            this.txtp.Size = new System.Drawing.Size(100, 22);
            this.txtp.TabIndex = 6;
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(229, 167);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(100, 22);
            this.txtc.TabIndex = 7;
            this.txtc.TextChanged += new System.EventHandler(this.txtc_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(428, 280);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.txtp);
            this.Controls.Add(this.txtu);
            this.Controls.Add(this.btnr);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.lblpa);
            this.Controls.Add(this.lblp);
            this.Controls.Add(this.lblerror);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.Label lblp;
        private System.Windows.Forms.Label lblpa;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Button btnr;
        private System.Windows.Forms.TextBox txtu;
        private System.Windows.Forms.TextBox txtp;
        private System.Windows.Forms.TextBox txtc;
    }
}