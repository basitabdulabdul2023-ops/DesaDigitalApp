# 🗺️ ROADMAP PENGEMBANGAN DESA DIGITAL APP

Dokumen ini menjelaskan tahapan kerja (FAZA) pengembangan aplikasi **DesaDigitalApp** berbasis .NET MAUI dengan backend Laravel API.  
Setiap fase memiliki target dan deliverable yang harus diselesaikan secara berurutan.

---

## ⚙️ FAZA 0 — PERSIAPAN UMUM ✅

### 🎯 Tujuan:
Menyiapkan seluruh lingkungan kerja (development environment) dan repositori agar pengembangan bisa berjalan stabil.

### 🧩 Langkah-langkah:
- [x] Instalasi Git dan koneksi GitHub
- [x] Setup Visual Studio 2022 dengan workload **.NET MAUI**
- [x] Pembuatan proyek `DesaDigitalApp`
- [x] Inisialisasi struktur MVVM (Models, Views, ViewModels, Services, Helpers)
- [x] Setup domain API (rencana: `api.desacikande.com`)
- [x] Dokumentasi awal (`README.md`, `ROADMAP.md`)

### 📦 Output:
- Repo GitHub aktif: `https://github.com/basitabdulabdul2023-ops/DesaDigitalApp`
- Struktur proyek dasar siap
- Dokumentasi internal tersedia

---

## 🧰 FAZA 1 — BACKEND API LARAVEL 🔧

### 🎯 Tujuan:
Menyiapkan dan menstabilkan **Laravel API Backend** agar bisa diakses oleh aplikasi MAUI.

### 📋 Rencana Implementasi:
- Setup Laravel 11 + Sanctum
- Struktur folder: `app/Http/Controllers/Api`, `routes/api.php`
- Endpoint utama:
  | Endpoint | Method | Deskripsi |
  |-----------|---------|-----------|
  | `/api/login` | POST | Login pengguna |
  | `/api/surat` | GET/POST | Data dan pengajuan surat |
  | `/api/video/upload` | POST | Upload video kegiatan |
  | `/api/check-license/{key}` | GET | Validasi lisensi aplikasi |
  | `/api/ping` | GET | Tes koneksi server |
- Koneksi MySQL + Seeder awal
- Testing dengan Postman

### 📦 Output:
- API Laravel online & bisa diakses MAUI
- Postman Collection terupload ke repo

---

## 📱 FAZA 2 — MAUI SKELETON (LOGIN & BERANDA) 🧩

### 🎯 Tujuan:
Membangun struktur dasar aplikasi MAUI dan menampilkan halaman awal.

### 📋 Rencana Implementasi:
- MVVM Folder structure
- `LoginPage.xaml` + koneksi API login
- `ApiService.cs` (class untuk komunikasi API)
- `BerandaPage.xaml` dengan video background (contoh: `airterjun.mp4`)
- Navigasi berbasis `Shell` (AppShell.xaml)
- Implementasi dependency injection (`MauiProgram.cs`)

### 📦 Output:
- Aplikasi bisa login dan masuk ke beranda
- Tampilan video background aktif di Windows/Android

---

## 🔐 FAZA 3 — TOKEN & LICENSE SYSTEM 🛡️

### 🎯 Tujuan:
Menambahkan sistem keamanan aplikasi agar hanya pengguna dan lisensi sah yang bisa menggunakan.

### 📋 Rencana Implementasi:
- Token-based Authentication (JWT dari Laravel)
- Penyimpanan token di `SecureStorage`
- Validasi license key dari endpoint `/api/check-license`
- Menambahkan middleware pengecekan lisensi
- Fitur logout & refresh token otomatis

### 📦 Output:
- Login dan lisensi berjalan penuh
- Token tersimpan dan diperbarui otomatis

---

## 📄 FAZA 4 — CRUD SURAT (OFFLINE-FIRST) 📨

### 🎯 Tujuan:
Memungkinkan pengguna menambah/mengedit surat bahkan saat offline, lalu sinkron otomatis saat online.

### 📋 Rencana Implementasi:
- Model `Surat` & service lokal SQLite
- Halaman CRUD Surat (`DaftarSuratPage`, `TambahSuratPage`)
- Status surat: *Pending*, *Terkirim*, *Gagal Upload*
- Queue system (background sync)
- API sync otomatis saat online

### 📦 Output:
- Surat bisa disimpan offline
- Sinkronisasi otomatis saat koneksi kembali tersedia

---

## 🎥 FAZA 5 — UPLOAD VIDEO 🎬

### 🎯 Tujuan:
Menambahkan fitur upload video kegiatan ke server desa.

### 📋 Rencana Implementasi:
- Halaman “Galeri Kegiatan”
- Integrasi API `/api/video/upload`
- Progress bar upload
- Retry otomatis jika gagal
- Preview video dan metadata
- Kompresi video opsional

### 📦 Output:
- Video berhasil diupload & ditampilkan di daftar kegiatan
- File tersimpan di server publik (misal `file.desacikande.com`)

---

## 🧩 FAZA 6 — DISTRIBUSI & PILOT PROJECT 🏁

### 🎯 Tujuan:
Menyiapkan paket instalasi (Windows & Android) dan melakukan uji coba di desa pilot.

### 📋 Rencana Implementasi:
- Build `.exe` (Windows) & `.apk` (Android)
- Uji coba performa di perangkat kantor desa
- Pembuatan panduan penggunaan (PDF & video)
- Dokumentasi feedback pengguna
- Deployment dan maintenance awal

### 📦 Output:
- Installer final tersedia
- Pilot Desa berjalan (Desa Cikande)
- Feedback user siap untuk iterasi berikutnya

---

## 🧾 Status Progres Global

| Faza | Target | Status | Estimasi |
|------|---------|:------:|----------|
| FAZA 0 | Setup & dokumentasi | ✅ Selesai | 100% |
| FAZA 1 | Backend API Laravel | ⏳ Dalam perencanaan | 40% |
| FAZA 2 | Skeleton & Login | 🔜 Segera dimulai | 0% |
| FAZA 3 | Token & License | 🔜 | 0% |
| FAZA 4 | CRUD Surat Offline | 🔜 | 0% |
| FAZA 5 | Upload Video | 🔜 | 0% |
| FAZA 6 | Installer & Pilot Desa | 🔜 | 0% |

---

## 📅 Catatan Perkembangan
> **Log update akan ditulis otomatis di sini tiap commit milestone utama:**
> - `2025-10-21` – Inisialisasi repo & dokumentasi dasar selesai (`README.md`, `ROADMAP.md`)
> - `2025-10-22` – Mulai pengembangan API Laravel (FAZA 1)
> - `2025-10-25` – Mulai implementasi LoginPage di MAUI (FAZA 2)
> - (update berikut akan diisi otomatis setiap fase selesai)

---

## 🧠 Catatan Akhir
Proyek **DesaDigitalApp** adalah fondasi sistem digitalisasi pelayanan desa modern berbasis *hybrid technology* (.NET MAUI + Laravel).  
Setiap FAZA harus didokumentasikan dan diuji agar integrasi API dan MAUI selalu sinkron.

> 💡 Motto: *“Bangun dari desa, bergerak dengan digital.”* 🌾💻
