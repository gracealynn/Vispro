namespace Daftar_fasilitas
{
    partial class signup
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxuser = new System.Windows.Forms.TextBox();
            this.txtboxpass = new System.Windows.Forms.TextBox();
            this.btnsignup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(373, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "SIGN UP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password :";
            // 
            // txtboxuser
            // 
            this.txtboxuser.Location = new System.Drawing.Point(380, 102);
            this.txtboxuser.Name = "txtboxuser";
            this.txtboxuser.Size = new System.Drawing.Size(286, 26);
            this.txtboxuser.TabIndex = 3;
            // 
            // txtboxpass
            // 
            this.txtboxpass.Location = new System.Drawing.Point(380, 155);
            this.txtboxpass.Name = "txtboxpass";
            this.txtboxpass.Size = new System.Drawing.Size(286, 26);
            this.txtboxpass.TabIndex = 4;
            // 
            // btnsignup
            // 
            this.btnsignup.Location = new System.Drawing.Point(591, 235);
            this.btnsignup.Name = "btnsignup";
            this.btnsignup.Size = new System.Drawing.Size(75, 35);
            this.btnsignup.TabIndex = 5;
            this.btnsignup.Text = "Sign Up";
            this.btnsignup.UseVisualStyleBackColor = true;
            this.btnsignup.Click += new System.EventHandler(this.btnsignup_Click);
            // 
            // signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 536);
            this.Controls.Add(this.btnsignup);
            this.Controls.Add(this.txtboxpass);
            this.Controls.Add(this.txtboxuser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "signup";
            this.Text = "signup";
            this.Load += new System.EventHandler(this.signup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxuser;
        private System.Windows.Forms.TextBox txtboxpass;
        private System.Windows.Forms.Button btnsignup;
    }
}