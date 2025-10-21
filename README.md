# 🏡 DesaDigitalApp

Aplikasi **Desa Digital** berbasis **.NET MAUI** yang terintegrasi dengan **Laravel API Backend**, dirancang untuk mendukung digitalisasi layanan administrasi desa — mulai dari login, pengajuan surat, pengelolaan video kegiatan, hingga sistem lisensi dan offline sync.

---

## 🎯 Tujuan Proyek

Mewujudkan aplikasi terpadu yang membantu perangkat desa:
- Mengelola layanan publik secara efisien dan modern
- Mempermudah pengajuan surat dan dokumen
- Menyediakan fitur multimedia (upload video kegiatan desa)
- Menjalankan sistem validasi lisensi dan akses offline
- Menyatukan backend Laravel dan frontend .NET MAUI dalam satu ekosistem

---

## 🧱 Teknologi yang Digunakan

| Komponen | Teknologi |
|-----------|------------|
| **Frontend (Mobile/Desktop)** | .NET MAUI (.NET 8) |
| **Backend API** | Laravel 11 (PHP 8.2) |
| **Database** | MySQL / MariaDB |
| **Storage** | Local + Cloud (S3/Public) |
| **Arsitektur App** | MVVM (Model–View–ViewModel) |
| **Version Control** | Git + GitHub |
| **Testing Tools** | Postman (API), MAUI Test |

---

## ⚙️ Struktur Folder Proyek
DesaDigitalApp/
├── Models/ → Kelas data (Surat, User, Video, dsb)
├── ViewModels/ → Logika & binding untuk setiap halaman (MVVM)
├── Views/ → Tampilan (.xaml + .xaml.cs)
├── Services/ → Koneksi API, DatabaseService, LicenseService
├── Helpers/ → Constants, helper umum
├── Resources/ → Style, Font, Gambar, Video (airterjun.mp4)
├── App.xaml → Entry point aplikasi
├── AppShell.xaml → Navigasi antar halaman
└── MauiProgram.cs → Dependency Injection & konfigurasi Utama

---

## 🚀 Cara Menjalankan Aplikasi

### 🔹 Persiapan
Pastikan sudah terpasang:
- Visual Studio 2022 / 2025 dengan workload **.NET MAUI**
- Android SDK / Emulator
- .NET SDK 8.0 atau 9.0
- Git (v2.51+)
- Koneksi ke backend Laravel (API Desa Digital)

### 🔹 Jalankan Proyek
1. Clone repository:
   ```bash
   git clone https://github.com/basitabdulabdul2023-ops/DesaDigitalApp.git
   cd DesaDigitalApp

