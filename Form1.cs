using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace perrpustaakaan
{
    public partial class Form1 : Form
    {
        private MySqlConnection conn;

        public Form1()
        {
            InitializeComponent();
            string connectionString = "server=localhost;user=root;database=perpustakaan;port=3306;password=";
            conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();
                MessageBox.Show("Berhasil terhubung ke database.", "Koneksi Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal terhubung ke database:\n" + ex.Message, "Koneksi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadBuku();
        }

        private void LoadBuku()
        {
            listDaftarBuku.Items.Clear();
            cbBuku.Items.Clear();

            try
            {
                conn.Open();
                string query = "SELECT * FROM buku";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string info = $"{reader["id"]}. {reader["judul"]} - {reader["penulis"]} ({reader["tahun"]}) [{reader["genre"]}]";

                    if (!string.IsNullOrEmpty(reader["nama_peminjam"].ToString()))
                    {
                        info += $" | Dipinjam oleh: {reader["nama_peminjam"]}, {reader["lama_hari"]} hari, {reader["no_hp"]}";
                    }

                    listDaftarBuku.Items.Add(info);
                    cbBuku.Items.Add($"{reader["id"]}. {reader["judul"]}");
                }

                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat buku: " + ex.Message);
            }
        }

        private int AmbilIdDariString(string input)
        {
            string[] parts = input.Split('.');
            if (parts.Length > 0 && int.TryParse(parts[0], out int id))
                return id;
            return -1;
        }

        private void btnTambahBuku_Click(object sender, EventArgs e)
        {
            string judul = txtJudul.Text;
            string penulis = txtPenulis.Text;
            string tahun = txtTahun.Text;
            string genre = txtGenre.Text;

            try
            {
                conn.Open();
                string query = "INSERT INTO buku (judul, penulis, tahun, genre) VALUES (@judul, @penulis, @tahun, @genre)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@judul", judul);
                cmd.Parameters.AddWithValue("@penulis", penulis);
                cmd.Parameters.AddWithValue("@tahun", tahun);
                cmd.Parameters.AddWithValue("@genre", genre);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Buku berhasil ditambahkan.");
                LoadBuku();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan buku: " + ex.Message);
            }
        }

        private void btnCekBuku_Click(object sender, EventArgs e)
        {
            LoadBuku();
        }

        private void btnPinjam_Click(object sender, EventArgs e)
        {
            if (cbBuku.SelectedItem == null)
            {
                MessageBox.Show("Pilih buku yang ingin dipinjam.");
                return;
            }

            int id = AmbilIdDariString(cbBuku.SelectedItem.ToString());
            string nama = txtNama.Text;
            int lama = (int)numericLamaPinjam.Value;
            string nohp = ShowInputBox("Masukkan nomor HP peminjam:", "Nomor HP");

            if (string.IsNullOrWhiteSpace(nohp))
            {
                MessageBox.Show("Nomor HP tidak boleh kosong.");
                return;
            }

            try
            {
                conn.Open();
                string query = "UPDATE buku SET peminjam=@peminjam, lama_pinjam=@lama, no_hp=@nohp WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@peminjam", nama);
                cmd.Parameters.AddWithValue("@lama", lama);
                cmd.Parameters.AddWithValue("@nohp", nohp);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Buku berhasil dipinjam.");
                LoadBuku();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal meminjam buku: " + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listDaftarBuku.SelectedItem == null)
            {
                MessageBox.Show("Pilih buku yang ingin diedit.");
                return;
            }

            int id = AmbilIdDariString(listDaftarBuku.SelectedItem.ToString());

            string newJudul = ShowInputBox("Judul baru:", "Edit Judul");
            string newPenulis = ShowInputBox("Penulis baru:", "Edit Penulis");
            string newTahun = ShowInputBox("Tahun baru:", "Edit Tahun");
            string newGenre = ShowInputBox("Genre baru:", "Edit Genre");

            try
            {
                conn.Open();
                string query = "UPDATE buku SET judul=@judul, penulis=@penulis, tahun=@tahun, genre=@genre WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@judul", newJudul);
                cmd.Parameters.AddWithValue("@penulis", newPenulis);
                cmd.Parameters.AddWithValue("@tahun", newTahun);
                cmd.Parameters.AddWithValue("@genre", newGenre);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data buku berhasil diperbarui.");
                LoadBuku();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengedit buku: " + ex.Message);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (listDaftarBuku.SelectedItem == null)
            {
                MessageBox.Show("Pilih buku yang ingin dihapus.");
                return;
            }

            int id = AmbilIdDariString(listDaftarBuku.SelectedItem.ToString());

            try
            {
                conn.Open();
                string query = "DELETE FROM buku WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Buku berhasil dihapus.");
                LoadBuku();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus buku: " + ex.Message);
            }
        }

        // Custom InputBox (pengganti Microsoft.VisualBasic)
        private string ShowInputBox(string text, string title)
        {
            Form inputForm = new Form();
            inputForm.Width = 400;
            inputForm.Height = 150;
            inputForm.Text = title;
            Label lbl = new Label() { Left = 10, Top = 20, Text = text, Width = 360 };
            TextBox txt = new TextBox() { Left = 10, Top = 50, Width = 360 };
            Button btnOk = new Button() { Text = "OK", Left = 200, Width = 80, Top = 80, DialogResult = DialogResult.OK };
            Button btnCancel = new Button() { Text = "Batal", Left = 290, Width = 80, Top = 80, DialogResult = DialogResult.Cancel };

            inputForm.Controls.Add(lbl);
            inputForm.Controls.Add(txt);
            inputForm.Controls.Add(btnOk);
            inputForm.Controls.Add(btnCancel);
            inputForm.AcceptButton = btnOk;
            inputForm.CancelButton = btnCancel;

            return inputForm.ShowDialog() == DialogResult.OK ? txt.Text : "";
        }
    }
}
