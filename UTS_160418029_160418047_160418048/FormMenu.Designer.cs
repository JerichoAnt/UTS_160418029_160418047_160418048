namespace UTS_160418029_160418047_160418048
{
    partial class FormMenu
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPembeli
            // 
            this.buttonPembeli.Location = new System.Drawing.Point(205, 154);
            this.buttonPembeli.Name = "buttonPembeli";
            this.buttonPembeli.Size = new System.Drawing.Size(75, 23);
            this.buttonPembeli.TabIndex = 0;
            this.buttonPembeli.Text = "Pembeli";
            this.buttonPembeli.UseVisualStyleBackColor = true;
            // 
            // buttonPenjual
            // 
            this.buttonPenjual.Location = new System.Drawing.Point(399, 154);
            this.buttonPenjual.Name = "buttonPenjual";
            this.buttonPenjual.Size = new System.Drawing.Size(75, 23);
            this.buttonPenjual.TabIndex = 1;
            this.buttonPenjual.Text = "Penjual";
            this.buttonPenjual.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(548, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(609, 4);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(29, 13);
            this.labelUsername.TabIndex = 4;
            this.labelUsername.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(667, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Role";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(702, 4);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(29, 13);
            this.labelRole.TabIndex = 6;
            this.labelRole.Text = "User";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonPenjual);
            this.Controls.Add(this.buttonPembeli);
            this.IsMdiContainer = true;
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPembeli;
        private System.Windows.Forms.Button buttonPenjual;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label labelUsername;
        public System.Windows.Forms.Label labelRole;
    }
}