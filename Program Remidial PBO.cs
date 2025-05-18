using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace UTS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MahasiswaManager mhsMgr = new MahasiswaManager();
            bool lanjut = true;

            while (lanjut)
            {
                Console.Clear();
                Console.WriteLine("\n+======================+");
                Console.WriteLine("|      Menu Utama      |");
                Console.WriteLine("+======================+");
                Console.WriteLine("| 1. Tambah Mahasiswa  |");
                Console.WriteLine("| 2. Lihat Mahasiswa   |");
                Console.WriteLine("| 3. Update Mahasiswa  |");
                Console.WriteLine("| 4. Hapus Mahasiswa   |");
                Console.WriteLine("| 5. Keluar            |");
                Console.WriteLine("+======================+");
                Console.Write("Pilih (1-5): ");
                string pilihanMenu = Console.ReadLine();


                if (pilihanMenu == "1")
                {
                    Console.Write("Masukkan NIM    : ");
                    string inputNim = Console.ReadLine();
                    Console.Write("Masukkan Nama   : ");
                    string inputNama = Console.ReadLine();
                    Console.Write("Masukkan Jurusan: ");
                    string inputJurusan = Console.ReadLine();
                    mhsMgr.Tambah(new Mahasiswa(inputNim, inputNama, inputJurusan));
                }
                else if (pilihanMenu == "2")
                {
                    mhsMgr.LihatSemua();
                }
                else if (pilihanMenu == "3")
                {
                    Console.Write("Masukkan NIM yang akan diupdate: ");
                    string updateNim = Console.ReadLine();
                    mhsMgr.Update(updateNim);
                }
                else if (pilihanMenu == "4")
                {
                    Console.Write("Masukkan NIM yang akan dihapus: ");
                    string hapusNim = Console.ReadLine();
                    mhsMgr.Hapus(hapusNim);
                }
                else if (pilihanMenu == "5")
                {
                    lanjut = false;
                    Console.WriteLine("Keluar dari program. Terima kasih!");
                }
                else
                {
                    Console.WriteLine("Pilihan tidak valid. Silakan pilih 1-5.");
                }

                if (lanjut)
                {
                    Console.WriteLine("\nTekan ENTER untuk kembali ke menu...");
                    Console.ReadLine();
                }
            }
        }
    }
    public abstract class Orang
    {
        private string nim;
        private string nama;
        public string NIM
        {
            get { return nim; }
            set { nim = value; }
        }

        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        protected Orang(string nim, string nama)
        {
            NIM = nim;
            Nama = nama;
        }

        public abstract void PrintInfo();
    }
    public class Mahasiswa : Orang
    {
        private string jurusan;

        public string Jurusan
        {
            get { return jurusan; }
            set { jurusan = value; }
        }

        public Mahasiswa(string nim, string nama, string jurusan)
            : base(nim, nama)
        {
            Jurusan = jurusan;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("NIM: " + NIM + ", Nama: " + Nama + ", Jurusan: " + Jurusan);
        }
    }

    public class MahasiswaManager
    {
        private List<Orang> daftarMahasiswa = new List<Orang>();

        public void Tambah(Orang dataMhs)
        {
            foreach (var item in daftarMahasiswa)
            {
                if (item.NIM == dataMhs.NIM)
                {
                    Console.WriteLine("Error: NIM sudah ada, tidak boleh duplikat.");
                    return;
                }
            }

            daftarMahasiswa.Add(dataMhs);
            Console.WriteLine("Data mahasiswa berhasil ditambahkan.");
        }

        public void LihatSemua()
        {
            if (daftarMahasiswa.Count == 0)
            {
                Console.WriteLine("Belum ada data mahasiswa.");
                return;
            }

            Console.WriteLine("\nDaftar Mahasiswa:");
            foreach (var m in daftarMahasiswa)
            {
                m.PrintInfo();
            }
        }

        public void Update(string cariNim)
        {
            Mahasiswa mhsItem = null;
            foreach (var item in daftarMahasiswa)
            {
                if (item.NIM == cariNim && item is Mahasiswa)
                {
                    mhsItem = item as Mahasiswa;
                    break;
                }
            }

            if (mhsItem == null)
            {
                Console.WriteLine("Error: NIM tidak ditemukan atau bukan Mahasiswa.");
                return;
            }

            Console.Write("Nama baru: ");
            string namaBaru = Console.ReadLine();
            Console.Write("Jurusan baru: ");
            string jurusanBaru = Console.ReadLine();

            mhsItem.Nama = namaBaru;
            mhsItem.Jurusan = jurusanBaru;
            Console.WriteLine("Data mahasiswa berhasil diupdate.");
        }

        public void Hapus(string cariNim)
        {
            Orang mhsItem = null;
            foreach (var item in daftarMahasiswa)
            {
                if (item.NIM == cariNim)
                {
                    mhsItem = item;
                    break;
                }
            }

            if (mhsItem == null)
            {
                Console.WriteLine("Error: NIM tidak ditemukan.");
                return;
            }

            daftarMahasiswa.Remove(mhsItem);
            Console.WriteLine("Data mahasiswa berhasil dihapus.");
        }
    }
}
