namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            folderBrowserDialog1 = new FolderBrowserDialog();
            label1 = new Label();
            BtnKonumSec = new Button();
            openFileDialog1 = new OpenFileDialog();
            BtnOpenFileDialog = new Button();
            BtnSaveFileDialog = new Button();
            saveFileDialog1 = new SaveFileDialog();
            TxtYol = new TextBox();
            label2 = new Label();
            BtnOlustur = new Button();
            BtnKonum = new Button();
            label3 = new Label();
            TxtAd = new TextBox();
            BtnOku = new Button();
            listBox1 = new ListBox();
            BtnYazdir = new Button();
            richTextBox1 = new RichTextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 221);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 1;
            label1.Text = "Kaydedilecek Yazı:";
            // 
            // BtnKonumSec
            // 
            BtnKonumSec.Location = new Point(489, 12);
            BtnKonumSec.Name = "BtnKonumSec";
            BtnKonumSec.Size = new Size(185, 27);
            BtnKonumSec.TabIndex = 2;
            BtnKonumSec.Text = "Folder Browser Dialog";
            BtnKonumSec.UseVisualStyleBackColor = true;
            BtnKonumSec.Click += BtnKonumSec_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnOpenFileDialog
            // 
            BtnOpenFileDialog.Location = new Point(489, 49);
            BtnOpenFileDialog.Name = "BtnOpenFileDialog";
            BtnOpenFileDialog.Size = new Size(185, 27);
            BtnOpenFileDialog.TabIndex = 3;
            BtnOpenFileDialog.Text = "Open File Dialog";
            BtnOpenFileDialog.UseVisualStyleBackColor = true;
            BtnOpenFileDialog.Click += BtnOpenFileDialog_Click;
            // 
            // BtnSaveFileDialog
            // 
            BtnSaveFileDialog.Location = new Point(489, 82);
            BtnSaveFileDialog.Name = "BtnSaveFileDialog";
            BtnSaveFileDialog.Size = new Size(185, 27);
            BtnSaveFileDialog.TabIndex = 4;
            BtnSaveFileDialog.Text = "Save File Dialog";
            BtnSaveFileDialog.UseVisualStyleBackColor = true;
            BtnSaveFileDialog.Click += BtnSaveFileDialog_Click;
            // 
            // TxtYol
            // 
            TxtYol.Location = new Point(95, 9);
            TxtYol.Name = "TxtYol";
            TxtYol.Size = new Size(189, 27);
            TxtYol.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 6;
            label2.Text = "Belge Yolu:";
            label2.Click += label2_Click;
            // 
            // BtnOlustur
            // 
            BtnOlustur.Location = new Point(489, 148);
            BtnOlustur.Name = "BtnOlustur";
            BtnOlustur.Size = new Size(185, 27);
            BtnOlustur.TabIndex = 7;
            BtnOlustur.Text = "Oluştur";
            BtnOlustur.UseVisualStyleBackColor = true;
            BtnOlustur.Click += BtnOlustur_Click;
            // 
            // BtnKonum
            // 
            BtnKonum.Location = new Point(489, 115);
            BtnKonum.Name = "BtnKonum";
            BtnKonum.Size = new Size(185, 27);
            BtnKonum.TabIndex = 8;
            BtnKonum.Text = "Konum Seç";
            BtnKonum.UseVisualStyleBackColor = true;
            BtnKonum.Click += BtnKonum_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 63);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 10;
            label3.Text = "Belge Adı:";
            // 
            // TxtAd
            // 
            TxtAd.Location = new Point(95, 60);
            TxtAd.Name = "TxtAd";
            TxtAd.Size = new Size(189, 27);
            TxtAd.TabIndex = 9;
            // 
            // BtnOku
            // 
            BtnOku.Location = new Point(489, 181);
            BtnOku.Name = "BtnOku";
            BtnOku.Size = new Size(185, 27);
            BtnOku.TabIndex = 11;
            BtnOku.Text = "Oku";
            BtnOku.UseVisualStyleBackColor = true;
            BtnOku.Click += BtnOku_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(12, 144);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(272, 64);
            listBox1.TabIndex = 12;
            // 
            // BtnYazdir
            // 
            BtnYazdir.Location = new Point(489, 214);
            BtnYazdir.Name = "BtnYazdir";
            BtnYazdir.Size = new Size(185, 27);
            BtnYazdir.TabIndex = 13;
            BtnYazdir.Text = "Yazdır";
            BtnYazdir.UseVisualStyleBackColor = true;
            BtnYazdir.Click += BtnYazdir_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 244);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(272, 136);
            richTextBox1.TabIndex = 14;
            richTextBox1.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 115);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 15;
            label4.Text = "Okunan Yazı:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 392);
            Controls.Add(label4);
            Controls.Add(richTextBox1);
            Controls.Add(BtnYazdir);
            Controls.Add(listBox1);
            Controls.Add(BtnOku);
            Controls.Add(label3);
            Controls.Add(TxtAd);
            Controls.Add(BtnKonum);
            Controls.Add(BtnOlustur);
            Controls.Add(label2);
            Controls.Add(TxtYol);
            Controls.Add(BtnSaveFileDialog);
            Controls.Add(BtnOpenFileDialog);
            Controls.Add(BtnKonumSec);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FolderBrowserDialog folderBrowserDialog1;
        private Label label1;
        private Button BtnKonumSec;
        private OpenFileDialog openFileDialog1;
        private Button BtnOpenFileDialog;
        private Button BtnSaveFileDialog;
        private SaveFileDialog saveFileDialog1;
        private TextBox TxtYol;
        private Label label2;
        private Button BtnOlustur;
        private Button BtnKonum;
        private Label label3;
        private TextBox TxtAd;
        private Button BtnOku;
        private ListBox listBox1;
        private Button BtnYazdir;
        private RichTextBox richTextBox1;
        private Label label4;
    }
}