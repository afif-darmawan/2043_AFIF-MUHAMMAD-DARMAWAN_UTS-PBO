using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("\n");
                Console.WriteLine("+======================+");
                Console.WriteLine("|      Menu Utama      |");
                Console.WriteLine("+======================+");
                Console.WriteLine("| 1. Tambah Mahasiswa  |");
                Console.WriteLine("| 2. Lihat Mahasiswa   |");
                Console.WriteLine("| 3. Update Mahasiswa  |");
                Console.WriteLine("| 4. Hapus Mahasiswa   |");
                Console.WriteLine("|                      |");
                Console.WriteLine("| 5. Keluar            |");
                Console.WriteLine("+======================+");
                Console.Write("  Pilih (1-5): ");
                string pilih = Console.ReadLine();

                if (pilih == "1")
                {
                    Console.WriteLine("\n");
                    Console.Write("Masukkan NIM    : ");
                    string nim = Console.ReadLine();
                    Console.Write("Masukkan Nama   : ");
                    string nama = Console.ReadLine();
                    Console.Write("Masukkan Jurusan: ");
                    string jurusan = Console.ReadLine();
                    Console.WriteLine("\n");
                    Console.WriteLine("Mohon Maaf : Aplikasi dalam masa pengembangan karena keterbatasan waktu");
                }
                else if (pilih == "2")
                {
                    Console.WriteLine("Belum ada data mahasiswa");
                    Console.WriteLine("\n");
                    Console.WriteLine("Mohon Maaf : Aplikasi dalam masa pengembangan karena keterbatasan waktu");
                }
                else if (pilih == "3")
                {
                    Console.Write("Masukkan NIM baru    : ");
                    string nim = Console.ReadLine();
                    Console.Write("Masukkan Nama baru   : ");
                    string namaBaru = Console.ReadLine();
                    Console.Write("Masukkan Jurusan baru: ");
                    string jurusanBaru = Console.ReadLine();
                    Console.WriteLine("\n");
                    Console.WriteLine("Mohon Maaf : Aplikasi dalam masa pengembangan karena keterbatasan waktu");
                }
                else if (pilih == "4")
                {
                    Console.Write("Masukkan NIM yang akan dihapus: ");
                    string nim = Console.ReadLine();
                    Console.WriteLine("\n");
                    Console.WriteLine("Mohon Maaf : Aplikasi dalam masa pengembangan karena keterbatasan waktu");
                }
                else if (pilih == "5")
                {}
                else
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Pilihan tidak valid");
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("Program selesai...");
            Console.WriteLine("Terima Kasih");
        }
    }
    public class Sosok
    {
        public string Nama;
    }

    public class Mahasiswa:Sosok
    {
        public string NIM {get; private set;}
        public string Jurusan;

        public Mahasiswa(string nim, string nama, string jurusan)
        {
            NIM = nim;
            Nama = nama;
            Jurusan = jurusan;
        }
    }
}