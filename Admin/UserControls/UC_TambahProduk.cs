using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Admin.ProdukSpek;
using System.Text.Json;
using System.Diagnostics;

namespace Admin.UserControls
{
    public partial class UC_TambahProduk : UserControl
    {
        List<Produk> products = new List<Produk>();
        string filePath = "C:\\Programing\\C#\\AdminBaru\\Admin\\Admin\\bin\\Debug\\ProductsSolarPanels.JSON";

        public UC_TambahProduk()
        {
            InitializeComponent();
        }


        private void UC_List_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Judul Tambah Produk

        }

        private void labelNamaProduk_Click(object sender, EventArgs e)
        {

        }

        private void labelTipeProduk_Click(object sender, EventArgs e)
        {

        }

        private void labelHargaProduk_Click(object sender, EventArgs e)
        {

        }

        private void labelPanjangProduk_Click(object sender, EventArgs e)
        {

        }

        private void labelLebarProduk_Click(object sender, EventArgs e)
        {

        }

        private void labelStokProduk_Click(object sender, EventArgs e)
        {

        }

        private void labelDeskripsiProduk_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNamaProduk_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLebarProduk_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStokProduk_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDeskProduk_TextChanged(object sender, EventArgs e)
        {

        }
        s
        public class Produk
        {
            public string namaproduk { get; set; }
            public string jenis { get; set; }
            public string idProduk { get; set; }
            public string hargaProduk { get; set; }
            public string panjangProduk { get; set; }
            public string lebarProduk { get; set; }
            public int stokProduk { get; set; }
            public string deskripsiProduk { get; set; }
        }

        private void submitTambah_Click(object sender, EventArgs e)
        {
            string inputNamaProduk, inputJenisProduk, inputHargaProduk, inputPanjangProduk, inputLebarProduk, inputDeskripsiProduk;
            int inputStokProduk;

            // Inisialisasi objek dari kelas Random
            Random inputID = new Random();

            // Membuat 4 teks angka acak
            string randomText = "";
            for (int i = 0; i < 4; i++)
            {
                // Menghasilkan angka acak antara 0 dan 9
                int randomNumber = inputID.Next(10);

                // Menambahkan angka acak ke teks
                randomText += randomNumber.ToString();
            }

            inputNamaProduk = textBoxNamaProduk.Text;
            inputJenisProduk = textBoxTipeProduk.Text;
            inputHargaProduk = textBoxHargaProduk.Text;
            inputPanjangProduk = textBoxPanjangProduk.Text;
            inputLebarProduk = textBoxLebarProduk.Text;
            inputStokProduk = int.Parse(textBoxStokProduk.Text);
            inputDeskripsiProduk = textBoxDeskProduk.Text;

            // Membaca data dari file JSON
            string json = File.ReadAllText(filePath);

            // Deserialisasi data JSON menjadi daftar objek Produk
            List<Produk> produkList = JsonConvert.DeserializeObject<List<Produk>>(json);
            products = produkList.ToList();
            products.Add(new Produk(randomText, inputNamaProduk, inputJenisProduk, inputHargaProduk, inputPanjangProduk, inputLebarProduk, inputStokProduk, inputDeskripsiProduk));
 

            foreach (var Produk in products)
            {
                Console.WriteLine(Produk.namaproduk);
            }



            // Bagian Buat Create File
            var HasilKonversi = JsonConvert.SerializeObject(products);

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true,
            };

            //FileStream fileStream = new FileStream("C:\\Programing\\C#\\AdminBaru\\Admin\\Admin\\bin\\Debug\\ProductsSolarPanels.JSON", FileMode.Create);
            using (StreamWriter write = new StreamWriter(filePath))
            {
                write.Write(HasilKonversi);
            }

            // Menampilkan teks di MessageBox   
            // MessageBox.Show("Data yang diambil dari TextBox: " + inputNamaProduk + inputJenisProduk + inputHargaProduk + inputPanjangProduk + inputLebarProduk + inputStokProduk + inputDeskripsiProduk);
        }
    }
}
