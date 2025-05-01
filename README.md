# 📚 Aplikasi Perpustakaan - Windows Forms (C# + MySQL)

Aplikasi Perpustakaan ini merupakan program berbasis **Windows Forms** menggunakan **C#** yang terhubung langsung ke **database MySQL**. Aplikasi ini memungkinkan pengguna untuk mengelola data buku, proses peminjaman, dan pengembalian buku dengan mudah melalui antarmuka yang sederhana namun fungsional.

---

## ⚙️ Teknologi yang Digunakan

- C# (.NET Framework)
- Windows Forms
- MySQL
- MySql.Data (Connector/NET)

---

## 🧩 Struktur Tabel Database

- **`buku`**  
  Menyimpan data buku: id, judul, penulis, tahun_terbit, genre.

- **`peminjaman`**  
  Menyimpan data peminjaman: id, id_buku, nama_peminjam, lama_pinjam, no_hp.

---

## ✨ Fitur Utama

### 1. **Tambah Buku**
- Input data buku melalui form (Judul, Penulis, Tahun Terbit, Genre).
- Data disimpan ke tabel `buku` dan langsung muncul di daftar.

### 2. **Pinjam Buku**
- Memilih buku yang tersedia dari daftar.
- Input data peminjam: Nama, Lama Pinjam (hari), dan No. HP.
- Disimpan ke tabel `peminjaman` dan status buku berubah menjadi **Dipinjam**.

### 3. **Daftar Buku**
- Menampilkan seluruh buku dari database.
- Menampilkan status buku (Tersedia / Dipinjam).
- **Edit Buku**: Mengubah informasi buku.
- **Hapus Buku**: Menghapus data buku dari database.
- **Kembalikan Buku**: Menghapus data dari tabel `peminjaman`, status buku kembali **Tersedia**.

---

## 📦 Struktur Form

Semua fitur diakses dalam satu form (`Form1.cs`) dengan tiga tab:
- **Tambah Buku**
- **Pinjam Buku**
- **Daftar Buku**

---

## 🏁 Cara Menjalankan

1. Pastikan MySQL Server aktif dan database sudah dibuat.
2. Sesuaikan string koneksi di `Form1.cs` dengan konfigurasi MySQL kamu.
3. Jalankan aplikasi dari Visual Studio.

---

## 🔐 Catatan

- Aplikasi tidak menggunakan placeholder atau InputBox.
- Tidak ada pemrosesan langsung dengan `ExecuteNonQuery` — menggunakan `MySqlCommand` dengan parameter yang aman.

---

## DESAIN MocKup
[*Tambahkan screenshot tampilan aplikasi di sini jika dipe] 
(https://www.figma.com/design/1IYJHVj4Z5FhmvE1N1LSYG/Untitled?node-id=1-161&p=f&t=VGGMvEOWAQLNdsXo-0)


---

## 🧑‍💻 Pengembang

Dibuat oleh untuk keperluan tugas/project manajemen perpustakaan.
---
Mochammad Atur Akbar Loredo H.P (2213020006)
---
Rina Padila Febriani (2213020170) 
---

