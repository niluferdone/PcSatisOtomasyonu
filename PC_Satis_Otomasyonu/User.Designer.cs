namespace PC_Satis_Otomasyonu
{
    partial class User
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.urunlerim = new System.Windows.Forms.ListView();
            this.seri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MusteriID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urunad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.garanti = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SimdikiTarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.satis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kalan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.aramaListesi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader29 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.islemciHiziCombo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.islemciSiralaCombo = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.markaSiralaCombo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fiyatSiralaCombo = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.satınAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(932, 327);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.urunlerim);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(924, 301);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ürünlerim";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // urunlerim
            // 
            this.urunlerim.CheckBoxes = true;
            this.urunlerim.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.seri,
            this.id,
            this.urunad,
            this.MusteriID,
            this.garanti,
            this.SimdikiTarih,
            this.satis,
            this.kalan});
            this.urunlerim.ContextMenuStrip = this.contextMenuStrip1;
            this.urunlerim.GridLines = true;
            this.urunlerim.Location = new System.Drawing.Point(6, 6);
            this.urunlerim.Name = "urunlerim";
            this.urunlerim.Size = new System.Drawing.Size(912, 289);
            this.urunlerim.TabIndex = 10;
            this.urunlerim.UseCompatibleStateImageBehavior = false;
            this.urunlerim.View = System.Windows.Forms.View.Details;
            // 
            // seri
            // 
            this.seri.Text = "Seri No";
            this.seri.Width = 118;
            // 
            // id
            // 
            this.id.Text = "Ürün ID";
            this.id.Width = 92;
            // 
            // MusteriID
            // 
            this.MusteriID.Text = "Müşteri ID";
            this.MusteriID.Width = 104;
            // 
            // urunad
            // 
            this.urunad.Text = "Ürün Adı";
            this.urunad.Width = 130;
            // 
            // garanti
            // 
            this.garanti.Text = "Garanti Süresi";
            this.garanti.Width = 96;
            // 
            // SimdikiTarih
            // 
            this.SimdikiTarih.Text = "Tarih";
            this.SimdikiTarih.Width = 87;
            // 
            // satis
            // 
            this.satis.Text = "Satış Tarihi";
            this.satis.Width = 106;
            // 
            // kalan
            // 
            this.kalan.Text = "Kalan Garanti Süresi";
            this.kalan.Width = 162;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.aramaListesi);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.islemciHiziCombo);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.islemciSiralaCombo);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.markaSiralaCombo);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.fiyatSiralaCombo);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(924, 301);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ürün İncele";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // aramaListesi
            // 
            this.aramaListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader27,
            this.columnHeader29,
            this.columnHeader13,
            this.columnHeader3,
            this.columnHeader23});
            this.aramaListesi.GridLines = true;
            this.aramaListesi.Location = new System.Drawing.Point(6, 83);
            this.aramaListesi.Name = "aramaListesi";
            this.aramaListesi.Size = new System.Drawing.Size(912, 212);
            this.aramaListesi.TabIndex = 10;
            this.aramaListesi.UseCompatibleStateImageBehavior = false;
            this.aramaListesi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Seri No";
            this.columnHeader1.Width = 67;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün ID";
            this.columnHeader2.Width = 84;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Ürün Adı";
            this.columnHeader19.Width = 89;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Marka";
            this.columnHeader20.Width = 98;
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "Fiyat";
            this.columnHeader27.Width = 77;
            // 
            // columnHeader29
            // 
            this.columnHeader29.Text = "İşlemci Hızı";
            this.columnHeader29.Width = 116;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "RAM Kapasitesi";
            this.columnHeader13.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "HDD Kapasitesi";
            this.columnHeader3.Width = 135;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Ekran Kartı";
            this.columnHeader23.Width = 118;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(657, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "İşlemci Hızı";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(732, 54);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 23);
            this.button4.TabIndex = 25;
            this.button4.Text = "Göster";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // islemciHiziCombo
            // 
            this.islemciHiziCombo.FormattingEnabled = true;
            this.islemciHiziCombo.Items.AddRange(new object[] {
            "1.7",
            "1.8",
            "2.0",
            "2.2",
            "2.3",
            "2.4",
            "2.5",
            "2.8",
            "3.0",
            "3.2",
            "3.5"});
            this.islemciHiziCombo.Location = new System.Drawing.Point(732, 27);
            this.islemciHiziCombo.Name = "islemciHiziCombo";
            this.islemciHiziCombo.Size = new System.Drawing.Size(128, 21);
            this.islemciHiziCombo.TabIndex = 24;
            this.islemciHiziCombo.Text = "1.7";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(417, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "İşlemci Tipi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(213, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Marka";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Fiyata Göre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(363, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "ARAMA SEÇENEKLERİ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(493, 54);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Göster";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // islemciSiralaCombo
            // 
            this.islemciSiralaCombo.FormattingEnabled = true;
            this.islemciSiralaCombo.Items.AddRange(new object[] {
            "Intel Core i3",
            "Intel Core i5",
            "Intel Core i7",
            "Intel Core 2 Duo",
            "Intel Celeron",
            "Intel Atom",
            "Intel Xeon",
            "AMD Athlon",
            "Intel Pentium",
            "AMD V Series",
            "AMD Turion"});
            this.islemciSiralaCombo.Location = new System.Drawing.Point(493, 27);
            this.islemciSiralaCombo.Name = "islemciSiralaCombo";
            this.islemciSiralaCombo.Size = new System.Drawing.Size(128, 21);
            this.islemciSiralaCombo.TabIndex = 18;
            this.islemciSiralaCombo.Text = "Intel i3";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(259, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Göster";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // markaSiralaCombo
            // 
            this.markaSiralaCombo.FormattingEnabled = true;
            this.markaSiralaCombo.Items.AddRange(new object[] {
            "Asus",
            "Lenovo",
            "Samsung",
            "Apple",
            "Acer",
            "MSI",
            "HP",
            "Casper",
            "Dell",
            "Monster",
            "Packard Bell"});
            this.markaSiralaCombo.Location = new System.Drawing.Point(259, 27);
            this.markaSiralaCombo.Name = "markaSiralaCombo";
            this.markaSiralaCombo.Size = new System.Drawing.Size(128, 21);
            this.markaSiralaCombo.TabIndex = 16;
            this.markaSiralaCombo.Text = "Asus";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fiyatSiralaCombo
            // 
            this.fiyatSiralaCombo.FormattingEnabled = true;
            this.fiyatSiralaCombo.Items.AddRange(new object[] {
            "Artan",
            "Azalan"});
            this.fiyatSiralaCombo.Location = new System.Drawing.Point(68, 27);
            this.fiyatSiralaCombo.Name = "fiyatSiralaCombo";
            this.fiyatSiralaCombo.Size = new System.Drawing.Size(128, 21);
            this.fiyatSiralaCombo.TabIndex = 14;
            this.fiyatSiralaCombo.Text = "Artan";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.satınAlToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(115, 26);
            // 
            // satınAlToolStripMenuItem
            // 
            this.satınAlToolStripMenuItem.Name = "satınAlToolStripMenuItem";
            this.satınAlToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.satınAlToolStripMenuItem.Text = "Satın Al";
            this.satınAlToolStripMenuItem.Click += new System.EventHandler(this.satınAlToolStripMenuItem_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 346);
            this.Controls.Add(this.tabControl1);
            this.Name = "User";
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView urunlerim;
        private System.Windows.Forms.ColumnHeader seri;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader urunad;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox islemciHiziCombo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox islemciSiralaCombo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox markaSiralaCombo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox fiyatSiralaCombo;
        private System.Windows.Forms.ColumnHeader MusteriID;
        private System.Windows.Forms.ColumnHeader garanti;
        private System.Windows.Forms.ColumnHeader SimdikiTarih;
        private System.Windows.Forms.ColumnHeader satis;
        private System.Windows.Forms.ColumnHeader kalan;
        private System.Windows.Forms.ListView aramaListesi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader27;
        private System.Windows.Forms.ColumnHeader columnHeader29;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem satınAlToolStripMenuItem;
    }
}