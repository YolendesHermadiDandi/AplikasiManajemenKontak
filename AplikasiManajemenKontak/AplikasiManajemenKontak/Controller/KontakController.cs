using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplikasiManajemenKontak.Model;

namespace AplikasiManajemenKontak.Controller
{
    public class KontakController
    {

        private static List<Kontak> daftarKontak = new List<Kontak>(); 
        public static void CreateKontak() 
        {

        
        }


        private static Kontak InputValidation()
        {
            String firstName;
            String lastName;
            String password;

            //Cek Validasi
            firstName = InputCheck("First Name : "); //cek inputan first name
            lastName = InputCheck("Last Name : "); // cek inputan last name
            password = InputCheck("Password : "); // cek inputan password


            //membuat username secara otomatis 
            String username = firstName.Substring(0, 2) + "" + lastName.Substring(0, 2);
            foreach (var item in daftarKaryawan)
            {
                if (item.Value.Username == username)
                {

                    username = username + "" + (++usernamecount);
                }
            }


            Kontak user = new Kontak();

            return user;
        }

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
                        checkvalidation = false;
                    }
                }else if (inputType.Equals("Email : "))
                {
                    Console.Write("Password : ");
                    input = Console.ReadLine();
                    if (input.Any(Char.Equals("@gmail.com")){

                    }
                }
             
                else if (inputType.Equals("Password : "))
                {
                    Console.Write("Password : ");
                    input = Console.ReadLine();
                    if (input.Length < 8 ||
                        !input.Any(Char.IsDigit) ||
                        !input.Any(Char.IsUpper) || !input.Any(Char.IsLower))
                    {
                        Console.WriteLine("PASSWORD MINIMAL MEMILIKI 8 KARAKTER !!");
                        Console.WriteLine("PASSWORD HARUS TERDIRI DARI HURUF BESAR, HURUF KECIL DAN ANGKA");
                    }
                    else
                    {
                        checkvalidation = false;
                    }

                }


            } while (checkvalidation);

            return input;

        }
    }
}
