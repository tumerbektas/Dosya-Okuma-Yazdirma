using System.IO;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnKonumSec_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            label1.Text = folderBrowserDialog1.SelectedPath;
        }

        private void BtnOpenFileDialog_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            label1.Text = openFileDialog1.FileName;
        }

        private void BtnSaveFileDialog_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        string belgeyolu, belgeadi;


        private void BtnKonum_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                belgeyolu = folderBrowserDialog1.SelectedPath;
                TxtYol.Text = belgeyolu;

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnOlustur_Click(object sender, EventArgs e)
        {
            belgeadi = TxtAd.Text;
            StreamWriter sw = File.CreateText(belgeyolu + "\\" + belgeadi + ".txt");
            MessageBox.Show("Belgeniz Baþarýyla Oluþturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnOku_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader oku = new StreamReader(openFileDialog1.FileName);
                string satir = oku.ReadLine();
                while (satir != null)
                {
                    listBox1.Items.Add(satir);
                    satir = oku.ReadLine();
                }
            }
        }

        private void BtnYazdir_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Metin Dosyasý |*.txt";
            saveFileDialog1.ShowDialog();
            StreamWriter kaydet = new StreamWriter(saveFileDialog1.FileName);
            kaydet.WriteLine(richTextBox1.Text);
            kaydet.Close();
            MessageBox.Show("Metin Belgesine kayýt yapýldý", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}