namespace Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PanelKiri = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TombolTambahProduk = new Guna.UI2.WinForms.Guna2Button();
            this.TombolListProduk = new Guna.UI2.WinForms.Guna2Button();
            this.PanelKanan = new System.Windows.Forms.Panel();
            this.PanelKiri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelKiri
            // 
            this.PanelKiri.BackColor = System.Drawing.Color.Navy;
            this.PanelKiri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelKiri.BackgroundImage")));
            this.PanelKiri.Controls.Add(this.pictureBox1);
            this.PanelKiri.Controls.Add(this.TombolTambahProduk);
            this.PanelKiri.Controls.Add(this.TombolListProduk);
            this.PanelKiri.Location = new System.Drawing.Point(0, 1);
            this.PanelKiri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelKiri.Name = "PanelKiri";
            this.PanelKiri.Size = new System.Drawing.Size(325, 838);
            this.PanelKiri.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(91, 48);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // TombolTambahProduk
            // 
            this.TombolTambahProduk.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.TombolTambahProduk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.TombolTambahProduk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.TombolTambahProduk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.TombolTambahProduk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.TombolTambahProduk.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(49)))));
            this.TombolTambahProduk.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TombolTambahProduk.ForeColor = System.Drawing.Color.White;
            this.TombolTambahProduk.Location = new System.Drawing.Point(0, 352);
            this.TombolTambahProduk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TombolTambahProduk.Name = "TombolTambahProduk";
            this.TombolTambahProduk.Size = new System.Drawing.Size(325, 82);
            this.TombolTambahProduk.TabIndex = 1;
            this.TombolTambahProduk.Text = "Tambah Produk";
            this.TombolTambahProduk.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // TombolListProduk
            // 
            this.TombolListProduk.BackColor = System.Drawing.Color.AliceBlue;
            this.TombolListProduk.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.TombolListProduk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.TombolListProduk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.TombolListProduk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.TombolListProduk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.TombolListProduk.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(49)))));
            this.TombolListProduk.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TombolListProduk.ForeColor = System.Drawing.Color.White;
            this.TombolListProduk.Location = new System.Drawing.Point(0, 265);
            this.TombolListProduk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TombolListProduk.Name = "TombolListProduk";
            this.TombolListProduk.PressedColor = System.Drawing.Color.DarkGray;
            this.TombolListProduk.Size = new System.Drawing.Size(325, 82);
            this.TombolListProduk.TabIndex = 0;
            this.TombolListProduk.Text = "List Produk";
            this.TombolListProduk.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // PanelKanan
            // 
            this.PanelKanan.Location = new System.Drawing.Point(323, 1);
            this.PanelKanan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelKanan.Name = "PanelKanan";
            this.PanelKanan.Size = new System.Drawing.Size(1104, 838);
            this.PanelKanan.TabIndex = 1;
            this.PanelKanan.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelKanan_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 716);
            this.Controls.Add(this.PanelKanan);
            this.Controls.Add(this.PanelKiri);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PanelKiri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelKiri;
        private Guna.UI2.WinForms.Guna2Button TombolTambahProduk;
        private Guna.UI2.WinForms.Guna2Button TombolListProduk;
        private System.Windows.Forms.Panel PanelKanan;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

