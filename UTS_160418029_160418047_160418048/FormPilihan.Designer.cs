namespace UTS_160418029_160418047_160418048
{
    partial class FormPilihan
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
            this.buttonDaftarBarang = new System.Windows.Forms.Button();
            this.buttonKatalog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRiwayat = new System.Windows.Forms.Button();
            this.buttonKeranjang = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonPromo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDaftarBarang
            // 
            this.buttonDaftarBarang.Location = new System.Drawing.Point(43, 112);
            this.buttonDaftarBarang.Name = "buttonDaftarBarang";
            this.buttonDaftarBarang.Size = new System.Drawing.Size(140, 125);
            this.buttonDaftarBarang.TabIndex = 0;
            this.buttonDaftarBarang.Text = "Daftar Barang";
            this.buttonDaftarBarang.UseVisualStyleBackColor = true;
            this.buttonDaftarBarang.Click += new System.EventHandler(this.buttonPembeli_Click);
            // 
            // buttonKatalog
            // 
            this.buttonKatalog.Location = new System.Drawing.Point(43, 274);
            this.buttonKatalog.Name = "buttonKatalog";
            this.buttonKatalog.Size = new System.Drawing.Size(140, 125);
            this.buttonKatalog.TabIndex = 1;
            this.buttonKatalog.Text = "Katalog Barang";
            this.buttonKatalog.UseVisualStyleBackColor = true;
            this.buttonKatalog.Click += new System.EventHandler(this.buttonPenjual_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu";
            // 
            // buttonRiwayat
            // 
            this.buttonRiwayat.Location = new System.Drawing.Point(536, 112);
            this.buttonRiwayat.Name = "buttonRiwayat";
            this.buttonRiwayat.Size = new System.Drawing.Size(140, 125);
            this.buttonRiwayat.TabIndex = 3;
            this.buttonRiwayat.Text = "Riwayat Transaksi";
            this.buttonRiwayat.UseVisualStyleBackColor = true;
            // 
            // buttonKeranjang
            // 
            this.buttonKeranjang.Location = new System.Drawing.Point(297, 274);
            this.buttonKeranjang.Name = "buttonKeranjang";
            this.buttonKeranjang.Size = new System.Drawing.Size(140, 125);
            this.buttonKeranjang.TabIndex = 4;
            this.buttonKeranjang.Text = "Keranjang";
            this.buttonKeranjang.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(569, 327);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(107, 72);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Keluar";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // buttonPromo
            // 
            this.buttonPromo.Location = new System.Drawing.Point(297, 112);
            this.buttonPromo.Name = "buttonPromo";
            this.buttonPromo.Size = new System.Drawing.Size(140, 125);
            this.buttonPromo.TabIndex = 6;
            this.buttonPromo.Text = "Promo";
            this.buttonPromo.UseVisualStyleBackColor = true;
            this.buttonPromo.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormPilihan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 450);
            this.Controls.Add(this.buttonPromo);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonKeranjang);
            this.Controls.Add(this.buttonRiwayat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKatalog);
            this.Controls.Add(this.buttonDaftarBarang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPilihan";
            this.Text = "FormPilihan";
            this.Load += new System.EventHandler(this.FormPilihan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDaftarBarang;
        private System.Windows.Forms.Button buttonKatalog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRiwayat;
        private System.Windows.Forms.Button buttonKeranjang;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonPromo;
    }
}