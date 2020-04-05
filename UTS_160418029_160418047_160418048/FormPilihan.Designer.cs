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
            this.buttonPembeli = new System.Windows.Forms.Button();
            this.buttonPenjual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPembeli
            // 
            this.buttonPembeli.Location = new System.Drawing.Point(159, 186);
            this.buttonPembeli.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPembeli.Name = "buttonPembeli";
            this.buttonPembeli.Size = new System.Drawing.Size(187, 154);
            this.buttonPembeli.TabIndex = 0;
            this.buttonPembeli.Text = "Pembeli";
            this.buttonPembeli.UseVisualStyleBackColor = true;
            this.buttonPembeli.Click += new System.EventHandler(this.buttonPembeli_Click);
            // 
            // buttonPenjual
            // 
            this.buttonPenjual.Location = new System.Drawing.Point(559, 186);
            this.buttonPenjual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPenjual.Name = "buttonPenjual";
            this.buttonPenjual.Size = new System.Drawing.Size(187, 154);
            this.buttonPenjual.TabIndex = 1;
            this.buttonPenjual.Text = "Penjual";
            this.buttonPenjual.UseVisualStyleBackColor = true;
            this.buttonPenjual.Click += new System.EventHandler(this.buttonPenjual_Click);
            // 
            // FormPilihan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.buttonPenjual);
            this.Controls.Add(this.buttonPembeli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPilihan";
            this.Text = "FormPilihan";
            this.Load += new System.EventHandler(this.FormPilihan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPembeli;
        private System.Windows.Forms.Button buttonPenjual;
    }
}