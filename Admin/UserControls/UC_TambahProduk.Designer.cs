namespace Admin.UserControls
{
    partial class UC_TambahProduk
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
            this.titleTambahProduk = new System.Windows.Forms.Label();
            this.labelNamaProduk = new System.Windows.Forms.Label();
            this.labelTipeProduk = new System.Windows.Forms.Label();
            this.labelHargaProduk = new System.Windows.Forms.Label();
            this.labelPanjangProduk = new System.Windows.Forms.Label();
            this.labelLebarProduk = new System.Windows.Forms.Label();
            this.labelStokProduk = new System.Windows.Forms.Label();
            this.labelDeskripsiProduk = new System.Windows.Forms.Label();
            this.textBoxNamaProduk = new System.Windows.Forms.TextBox();
            this.textBoxTipeProduk = new System.Windows.Forms.TextBox();
            this.textBoxHargaProduk = new System.Windows.Forms.TextBox();
            this.textBoxPanjangProduk = new System.Windows.Forms.TextBox();
            this.textBoxLebarProduk = new System.Windows.Forms.TextBox();
            this.textBoxStokProduk = new System.Windows.Forms.TextBox();
            this.textBoxDeskProduk = new System.Windows.Forms.TextBox();
            this.submitTambah = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleTambahProduk
            // 
            this.titleTambahProduk.AutoSize = true;
            this.titleTambahProduk.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTambahProduk.Location = new System.Drawing.Point(282, 92);
            this.titleTambahProduk.Name = "titleTambahProduk";
            this.titleTambahProduk.Size = new System.Drawing.Size(314, 31);
            this.titleTambahProduk.TabIndex = 0;
            this.titleTambahProduk.Text = "Masukkan Data Produk Baru";
            this.titleTambahProduk.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelNamaProduk
            // 
            this.labelNamaProduk.AutoSize = true;
            this.labelNamaProduk.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaProduk.Location = new System.Drawing.Point(44, 166);
            this.labelNamaProduk.Name = "labelNamaProduk";
            this.labelNamaProduk.Size = new System.Drawing.Size(178, 32);
            this.labelNamaProduk.TabIndex = 1;
            this.labelNamaProduk.Text = "Nama Produk";
            this.labelNamaProduk.Click += new System.EventHandler(this.labelNamaProduk_Click);
            // 
            // labelTipeProduk
            // 
            this.labelTipeProduk.AutoSize = true;
            this.labelTipeProduk.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipeProduk.Location = new System.Drawing.Point(44, 231);
            this.labelTipeProduk.Name = "labelTipeProduk";
            this.labelTipeProduk.Size = new System.Drawing.Size(158, 32);
            this.labelTipeProduk.TabIndex = 2;
            this.labelTipeProduk.Text = "Tipe Produk";
            this.labelTipeProduk.Click += new System.EventHandler(this.labelTipeProduk_Click);
            // 
            // labelHargaProduk
            // 
            this.labelHargaProduk.AutoSize = true;
            this.labelHargaProduk.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHargaProduk.Location = new System.Drawing.Point(44, 298);
            this.labelHargaProduk.Name = "labelHargaProduk";
            this.labelHargaProduk.Size = new System.Drawing.Size(180, 32);
            this.labelHargaProduk.TabIndex = 3;
            this.labelHargaProduk.Text = "Harga Produk";
            this.labelHargaProduk.Click += new System.EventHandler(this.labelHargaProduk_Click);
            // 
            // labelPanjangProduk
            // 
            this.labelPanjangProduk.AutoSize = true;
            this.labelPanjangProduk.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPanjangProduk.Location = new System.Drawing.Point(44, 367);
            this.labelPanjangProduk.Name = "labelPanjangProduk";
            this.labelPanjangProduk.Size = new System.Drawing.Size(205, 32);
            this.labelPanjangProduk.TabIndex = 4;
            this.labelPanjangProduk.Text = "Panjang Produk";
            this.labelPanjangProduk.Click += new System.EventHandler(this.labelPanjangProduk_Click);
            // 
            // labelLebarProduk
            // 
            this.labelLebarProduk.AutoSize = true;
            this.labelLebarProduk.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLebarProduk.Location = new System.Drawing.Point(44, 437);
            this.labelLebarProduk.Name = "labelLebarProduk";
            this.labelLebarProduk.Size = new System.Drawing.Size(176, 32);
            this.labelLebarProduk.TabIndex = 5;
            this.labelLebarProduk.Text = "Lebar Produk";
            this.labelLebarProduk.Click += new System.EventHandler(this.labelLebarProduk_Click);
            // 
            // labelStokProduk
            // 
            this.labelStokProduk.AutoSize = true;
            this.labelStokProduk.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStokProduk.Location = new System.Drawing.Point(44, 505);
            this.labelStokProduk.Name = "labelStokProduk";
            this.labelStokProduk.Size = new System.Drawing.Size(162, 32);
            this.labelStokProduk.TabIndex = 6;
            this.labelStokProduk.Text = "Stok Produk";
            this.labelStokProduk.Click += new System.EventHandler(this.labelStokProduk_Click);
            // 
            // labelDeskripsiProduk
            // 
            this.labelDeskripsiProduk.AutoSize = true;
            this.labelDeskripsiProduk.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeskripsiProduk.Location = new System.Drawing.Point(44, 570);
            this.labelDeskripsiProduk.Name = "labelDeskripsiProduk";
            this.labelDeskripsiProduk.Size = new System.Drawing.Size(220, 32);
            this.labelDeskripsiProduk.TabIndex = 7;
            this.labelDeskripsiProduk.Text = "Deskripsi Produk";
            this.labelDeskripsiProduk.Click += new System.EventHandler(this.labelDeskripsiProduk_Click);
            // 
            // textBoxNamaProduk
            // 
            this.textBoxNamaProduk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNamaProduk.Location = new System.Drawing.Point(330, 170);
            this.textBoxNamaProduk.Name = "textBoxNamaProduk";
            this.textBoxNamaProduk.Size = new System.Drawing.Size(510, 29);
            this.textBoxNamaProduk.TabIndex = 9;
            this.textBoxNamaProduk.TextChanged += new System.EventHandler(this.textBoxNamaProduk_TextChanged);
            // 
            // textBoxTipeProduk
            // 
            this.textBoxTipeProduk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTipeProduk.Location = new System.Drawing.Point(330, 235);
            this.textBoxTipeProduk.Name = "textBoxTipeProduk";
            this.textBoxTipeProduk.Size = new System.Drawing.Size(510, 29);
            this.textBoxTipeProduk.TabIndex = 10;
            // 
            // textBoxHargaProduk
            // 
            this.textBoxHargaProduk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHargaProduk.Location = new System.Drawing.Point(330, 302);
            this.textBoxHargaProduk.Name = "textBoxHargaProduk";
            this.textBoxHargaProduk.Size = new System.Drawing.Size(510, 29);
            this.textBoxHargaProduk.TabIndex = 11;
            // 
            // textBoxPanjangProduk
            // 
            this.textBoxPanjangProduk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPanjangProduk.Location = new System.Drawing.Point(330, 371);
            this.textBoxPanjangProduk.Name = "textBoxPanjangProduk";
            this.textBoxPanjangProduk.Size = new System.Drawing.Size(510, 29);
            this.textBoxPanjangProduk.TabIndex = 12;
            // 
            // textBoxLebarProduk
            // 
            this.textBoxLebarProduk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLebarProduk.Location = new System.Drawing.Point(330, 441);
            this.textBoxLebarProduk.Name = "textBoxLebarProduk";
            this.textBoxLebarProduk.Size = new System.Drawing.Size(510, 29);
            this.textBoxLebarProduk.TabIndex = 13;
            this.textBoxLebarProduk.TextChanged += new System.EventHandler(this.textBoxLebarProduk_TextChanged);
            // 
            // textBoxStokProduk
            // 
            this.textBoxStokProduk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStokProduk.Location = new System.Drawing.Point(330, 509);
            this.textBoxStokProduk.Name = "textBoxStokProduk";
            this.textBoxStokProduk.Size = new System.Drawing.Size(510, 29);
            this.textBoxStokProduk.TabIndex = 14;
            this.textBoxStokProduk.TextChanged += new System.EventHandler(this.textBoxStokProduk_TextChanged);
            // 
            // textBoxDeskProduk
            // 
            this.textBoxDeskProduk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDeskProduk.Location = new System.Drawing.Point(330, 574);
            this.textBoxDeskProduk.Name = "textBoxDeskProduk";
            this.textBoxDeskProduk.Size = new System.Drawing.Size(510, 29);
            this.textBoxDeskProduk.TabIndex = 15;
            this.textBoxDeskProduk.TextChanged += new System.EventHandler(this.textBoxDeskProduk_TextChanged);
            // 
            // submitTambah
            // 
            this.submitTambah.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitTambah.Location = new System.Drawing.Point(402, 638);
            this.submitTambah.Name = "submitTambah";
            this.submitTambah.Size = new System.Drawing.Size(97, 36);
            this.submitTambah.TabIndex = 16;
            this.submitTambah.Text = "Submit";
            this.submitTambah.UseVisualStyleBackColor = true;
            this.submitTambah.Click += new System.EventHandler(this.submitTambah_Click);
            // 
            // UC_TambahProduk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.submitTambah);
            this.Controls.Add(this.textBoxDeskProduk);
            this.Controls.Add(this.textBoxStokProduk);
            this.Controls.Add(this.textBoxLebarProduk);
            this.Controls.Add(this.textBoxPanjangProduk);
            this.Controls.Add(this.textBoxHargaProduk);
            this.Controls.Add(this.textBoxTipeProduk);
            this.Controls.Add(this.textBoxNamaProduk);
            this.Controls.Add(this.labelDeskripsiProduk);
            this.Controls.Add(this.labelStokProduk);
            this.Controls.Add(this.labelLebarProduk);
            this.Controls.Add(this.labelPanjangProduk);
            this.Controls.Add(this.labelHargaProduk);
            this.Controls.Add(this.labelTipeProduk);
            this.Controls.Add(this.labelNamaProduk);
            this.Controls.Add(this.titleTambahProduk);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_TambahProduk";
            this.Size = new System.Drawing.Size(1104, 838);
            this.Load += new System.EventHandler(this.UC_List_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleTambahProduk;
        private System.Windows.Forms.Label labelNamaProduk;
        private System.Windows.Forms.Label labelTipeProduk;
        private System.Windows.Forms.Label labelHargaProduk;
        private System.Windows.Forms.Label labelPanjangProduk;
        private System.Windows.Forms.Label labelLebarProduk;
        private System.Windows.Forms.Label labelStokProduk;
        private System.Windows.Forms.Label labelDeskripsiProduk;
        private System.Windows.Forms.TextBox textBoxNamaProduk;
        private System.Windows.Forms.TextBox textBoxTipeProduk;
        private System.Windows.Forms.TextBox textBoxHargaProduk;
        private System.Windows.Forms.TextBox textBoxPanjangProduk;
        private System.Windows.Forms.TextBox textBoxLebarProduk;
        private System.Windows.Forms.TextBox textBoxStokProduk;
        private System.Windows.Forms.TextBox textBoxDeskProduk;
        private System.Windows.Forms.Button submitTambah;
    }
}
