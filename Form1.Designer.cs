namespace perrpustaakaan
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTambah;
        private System.Windows.Forms.TabPage tabPinjam;
        private System.Windows.Forms.TabPage tabLihat;

        private System.Windows.Forms.GroupBox groupTambah;
        private System.Windows.Forms.GroupBox groupPinjam;
        private System.Windows.Forms.GroupBox groupDaftar;

        private System.Windows.Forms.TextBox txtJudul, txtPenulis, txtTahun, txtGenre, txtNama, txtNoHP;
        private System.Windows.Forms.Button btnTambahBuku, btnCekBuku, btnPinjam, btnEdit, btnHapus;
        private System.Windows.Forms.ComboBox cbBuku;
        private System.Windows.Forms.Label lblJudul, lblPenulis, lblTahun, lblGenre, lblNama, lblPilihBuku, lblLama, lblNoHP;
        private System.Windows.Forms.ListBox listDaftarBuku;
        private System.Windows.Forms.NumericUpDown numericLamaPinjam;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTambah = new System.Windows.Forms.TabPage();
            this.tabPinjam = new System.Windows.Forms.TabPage();
            this.tabLihat = new System.Windows.Forms.TabPage();

            this.groupTambah = new System.Windows.Forms.GroupBox();
            this.groupPinjam = new System.Windows.Forms.GroupBox();
            this.groupDaftar = new System.Windows.Forms.GroupBox();

            this.txtJudul = new System.Windows.Forms.TextBox();
            this.txtPenulis = new System.Windows.Forms.TextBox();
            this.txtTahun = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtNoHP = new System.Windows.Forms.TextBox();

            this.btnTambahBuku = new System.Windows.Forms.Button();
            this.btnCekBuku = new System.Windows.Forms.Button();
            this.btnPinjam = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();

            this.cbBuku = new System.Windows.Forms.ComboBox();

            this.lblJudul = new System.Windows.Forms.Label();
            this.lblPenulis = new System.Windows.Forms.Label();
            this.lblTahun = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblNoHP = new System.Windows.Forms.Label();
            this.lblPilihBuku = new System.Windows.Forms.Label();
            this.lblLama = new System.Windows.Forms.Label();

            this.listDaftarBuku = new System.Windows.Forms.ListBox();
            this.numericLamaPinjam = new System.Windows.Forms.NumericUpDown();

            // TabControl
            this.tabControl1.Controls.Add(this.tabTambah);
            this.tabControl1.Controls.Add(this.tabPinjam);
            this.tabControl1.Controls.Add(this.tabLihat);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 30);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;

            this.tabTambah.Text = "Tambah Buku";
            this.tabPinjam.Text = "Pinjam Buku";
            this.tabLihat.Text = "Lihat Buku";

            // GroupTambah
            this.groupTambah.Text = "Tambah Buku Baru";
            this.groupTambah.SetBounds(10, 10, 390, 270);

            lblJudul.Text = "Judul:"; lblJudul.SetBounds(20, 30, 100, 20);
            txtJudul.SetBounds(120, 30, 200, 25);

            lblPenulis.Text = "Penulis:"; lblPenulis.SetBounds(20, 70, 100, 20);
            txtPenulis.SetBounds(120, 70, 200, 25);

            lblTahun.Text = "Tahun Terbit:"; lblTahun.SetBounds(20, 110, 100, 20);
            txtTahun.SetBounds(120, 110, 200, 25);

            lblGenre.Text = "Genre:"; lblGenre.SetBounds(20, 150, 100, 20);
            txtGenre.SetBounds(120, 150, 200, 25);

            btnTambahBuku.Text = "Tambah Buku"; btnTambahBuku.SetBounds(50, 200, 120, 30);
            btnCekBuku.Text = "Cek Buku"; btnCekBuku.SetBounds(200, 200, 120, 30);

            groupTambah.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblJudul, txtJudul, lblPenulis, txtPenulis, lblTahun, txtTahun,
                lblGenre, txtGenre, btnTambahBuku, btnCekBuku });

            tabTambah.Controls.Add(groupTambah);

            // GroupPinjam
            this.groupPinjam.Text = "Formulir Peminjaman";
            this.groupPinjam.SetBounds(10, 10, 390, 270);

            lblNama.Text = "Nama Peminjam:"; lblNama.SetBounds(20, 30, 120, 20);
            txtNama.SetBounds(150, 30, 200, 25);

            lblPilihBuku.Text = "Pilih Buku:"; lblPilihBuku.SetBounds(20, 70, 100, 20);
            cbBuku.SetBounds(150, 70, 200, 25);

            lblLama.Text = "Lama Pinjam (hari):"; lblLama.SetBounds(20, 110, 120, 20);
            numericLamaPinjam.SetBounds(150, 110, 50, 25);
            numericLamaPinjam.Minimum = 1;
            numericLamaPinjam.Maximum = 30;

            lblNoHP.Text = "No HP:"; lblNoHP.SetBounds(20, 150, 100, 20);
            txtNoHP.SetBounds(150, 150, 200, 25);

            btnPinjam.Text = "Pinjam Buku"; btnPinjam.SetBounds(150, 190, 200, 30);

            groupPinjam.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblNama, txtNama,
                lblPilihBuku, cbBuku,
                lblLama, numericLamaPinjam,
                lblNoHP, txtNoHP,
                btnPinjam });

            tabPinjam.Controls.Add(groupPinjam);

            // GroupDaftar
            this.groupDaftar.Text = "Daftar Buku";
            this.groupDaftar.SetBounds(10, 10, 390, 300);

            listDaftarBuku.SetBounds(20, 30, 340, 180);

            btnEdit.Text = "Edit Buku"; btnEdit.SetBounds(50, 230, 120, 30);
            btnHapus.Text = "Hapus Buku"; btnHapus.SetBounds(200, 230, 120, 30);

            groupDaftar.Controls.AddRange(new System.Windows.Forms.Control[] {
                listDaftarBuku, btnEdit, btnHapus });

            tabLihat.Controls.Add(groupDaftar);

            // Form1
            this.Controls.Add(this.tabControl1);
            this.Text = "Aplikasi Perpustakaan";
            this.ClientSize = new System.Drawing.Size(430, 400);

            // Events
            btnTambahBuku.Click += new System.EventHandler(this.btnTambahBuku_Click);
            btnCekBuku.Click += new System.EventHandler(this.btnCekBuku_Click);
            btnPinjam.Click += new System.EventHandler(this.btnPinjam_Click);
            btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
        }
    }
}
