using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using AplikasiManajemenKontak.Model;

namespace AplikasiManajemenKontak.Controller
{
    public class KontakController
    {

        private static List<Kontak> daftarKontak = new List<Kontak> { };
        private static Stack<Kontak> historyKontak = new Stack<Kontak>(); 
        private static int id = 0;


        /*
         * 
         * Method dibawah digunakan untuk membuat kontak dan menambahkannya kedalam list
         * daftar kontak
         * 
         */

        public static void ShowAllKontak()
        {
            foreach (var item in daftarKontak)
            {
                Console.WriteLine(item.toString());
            }
        }
        /*Method untuk menampilkan history kontak yang sudah di delete*/
        public static void ShowHistoryAllKontak()
        {
            foreach (var item in historyKontak)
            {
                Console.WriteLine(item.toString());
            }
        }

        public static void CreateKontak()
        {

            Kontak user = InputValidation();
            daftarKontak.Add(user);
            Console.WriteLine("Data Berhasil Disimpan");
            String input = Console.ReadLine();

        }
        public static void UpdateKontak()
        {

            Console.WriteLine("============UPDATE KONTAK===========");
            Console.Write("Masukan Id yang ingin diupdate : ");
            String id = Console.ReadLine();

            if (daftarKontak.Count != 0)
            {

                foreach (var kontak in daftarKontak)
                {

                    if (kontak.Id == id)
                    {
                        Kontak user = InputValidation();
                        kontak.Name = user.Name;
                        kontak.PhoneNumber = user.PhoneNumber;
                        kontak.EmailAddress = user.EmailAddress;

                    }
                    else
                    {
                        Console.WriteLine("ID TIDAK DITEMUKAN");
                    }


                }
            }
            else
            {
                Console.WriteLine("DATA KONTAK KOSONG");
            }
            Console.ReadKey();
        }       
        public static void deleteKontak()
        {
            try
            {
                string input = Console.ReadLine();
                foreach (var item in daftarKontak)
                {
                    if (item.Id == input)
                    {
                        daftarKontak.Remove(item);
                        historyKontak.Push(item);
                    }
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine($"{e.Message}");
            }
            
           
        }
        
        public static void searchHistoryContact()
        {
            string search = Console.ReadLine();
            int count = 0;
            foreach (var item in historyKontak)
            {
                if (item.Name.Contains(search) || item.PhoneNumber.Contains(search) || item.EmailAddress.Contains(search))
                {
                    Console.WriteLine("========================");
                    Console.WriteLine("ID               : " + item.Id);
                    Console.WriteLine("Name             : " + item.Name);
                    Console.WriteLine("Phone Number     : " + item.PhoneNumber);
                    Console.WriteLine("Email Address    : " + item.EmailAddress);
                    Console.WriteLine("========================");
                    count++;
                }


            }
            if (count < 1)
            {
                Console.WriteLine("Maaf User Yang Anda Cari tidak ditemukan");
            }
            Console.ReadKey();
        }
        /*
         * Method dibawah digunakan untuk melakukan validasi terhadap inputan
         * dari user
         */
        private static Kontak InputValidation()
        {
            Console.Clear();
            Console.WriteLine("=== Create Contact Person ===");
            string name = InputCheck("Name : ");
            string phoneNumber = InputCheck("Phone Number : ");
            string emailAddress = InputCheck("Email : ");




            int idCount = ++id;
            Kontak kontak = new Kontak(idCount.ToString(), name, phoneNumber, emailAddress);

            return kontak;


        }

        /*
         * Method dibawah digunakan untuk validasi berdasarkan field yang diisi:
         * Name, Phone Number, dan Address
         */
        private static String InputCheck(String inputType)
        {
            Boolean checkvalidation = true;
            String input = "";

            do
            {
                if (inputType.Equals("Name : "))
                {

                    Console.Write(inputType);
                    input = Console.ReadLine();
                    if (string.IsNullOrEmpty(input) || input.Any(Char.IsDigit) || input.Length < 2)
                    {
                        Console.WriteLine("INPUTAN TIDAK FALID");

                    }
                    else
                    {
                        checkvalidation = RedudansiCheck(input);
                    }

                }
                else if (inputType.Equals("Phone Number : "))
                {
                    Console.Write(inputType);
                    input = Console.ReadLine();


                    if (input.Length < 8 ||
                        input.Length > 15 || input.Any(char.IsLetter))
                    {
                        Console.WriteLine("Phone Number tidak boleh kurang dari 8 atau lebih dari 15 atau huruf");
                    }
                    else
                    {
                        checkvalidation = RedudansiCheck(input);
                    }


                }
                else if (inputType.Equals("Email : "))
                {
                    Console.Write(inputType);
                    input = Console.ReadLine();

                    if (!input.Contains("@gmail.com"))
                    {
                        Console.WriteLine("EMAIL TIDAK VALID!!! \n Gunakan @gmail.com");
                    }
                    else
                    {
                        checkvalidation = RedudansiCheck(input);

                    }
                }


            } while (checkvalidation);


            return input;

        }

        private static Boolean RedudansiCheck(String input)
        {
            Boolean redudansicheck = false;
            String keterangan = "";
            foreach (var user in daftarKontak)
            {

                if (user.Name == input)
                {
                    keterangan = "Nama";
                    redudansicheck = true;
                }
                else if (user.PhoneNumber == input)
                {
                    keterangan = "Phone Number";
                    redudansicheck = true;
                }
                else if (user.EmailAddress == input)
                {
                    keterangan = "Email";
                    redudansicheck = true;
                }



            }
            if (redudansicheck == true)
            {
                Console.WriteLine(keterangan + " SUDAH DIGUNAKAN!!!");
                return true;
            }
            return false;

        }
    }
}
