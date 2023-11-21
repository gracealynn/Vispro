namespace Daftar_fasilitas
{
    partial class Homepage
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
            this.btnmahasiswa = new System.Windows.Forms.Button();
            this.btnfasilitas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnmahasiswa
            // 
            this.btnmahasiswa.Location = new System.Drawing.Point(160, 138);
            this.btnmahasiswa.Name = "btnmahasiswa";
            this.btnmahasiswa.Size = new System.Drawing.Size(168, 115);
            this.btnmahasiswa.TabIndex = 0;
            this.btnmahasiswa.Text = "Data Mahasiswa";
            this.btnmahasiswa.UseVisualStyleBackColor = true;
            this.btnmahasiswa.Click += new System.EventHandler(this.btnmahasiswa_Click);
            // 
            // btnfasilitas
            // 
            this.btnfasilitas.Location = new System.Drawing.Point(459, 138);
            this.btnfasilitas.Name = "btnfasilitas";
            this.btnfasilitas.Size = new System.Drawing.Size(168, 115);
            this.btnfasilitas.TabIndex = 1;
            this.btnfasilitas.Text = "Daftar Fasilitas";
            this.btnfasilitas.UseVisualStyleBackColor = true;
            this.btnfasilitas.Click += new System.EventHandler(this.btnfasilitas_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnfasilitas);
            this.Controls.Add(this.btnmahasiswa);
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnmahasiswa;
        private System.Windows.Forms.Button btnfasilitas;
    }
}