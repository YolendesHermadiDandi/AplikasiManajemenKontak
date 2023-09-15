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

        private static List<Kontak> daftarKontak = new List<Kontak> { };
        private static int id = 0;
        public static void CreateKontak()
        {

            Kontak user = InputValidation();
            daftarKontak.Add(user);
            Console.WriteLine("Data Berhasil Disimpan");
            String input = Console.ReadLine();

        }


        private static Kontak InputValidation()
        {
            string name = InputCheck("Name : ");
            string phoneNumber = InputCheck("Phone Number : ");
            string emailAddress = InputCheck("Email : ");




            int idCount = ++id;
            Kontak kontak = new Kontak(idCount.ToString(), name, phoneNumber, emailAddress);

            return kontak;


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
                    Boolean nameCheck = true;
                    foreach (var name in daftarKontak)
                    {
                        if (name.Name == input)
                        {
                            nameCheck = false;
                        }

                    }
                    if (nameCheck == false)
                    {
                        Console.WriteLine("NAMA TIDAK BOLEH SAMA!!!");
                    }
                    else
                    {
                        checkvalidation = false;
                    }

                }
                else if (inputType.Equals("Phone Number : "))
                {
                    Console.Write(inputType);
                    input = Console.ReadLine();
                    if (input.All(char.IsDigit))
                    {
                        if (input.Length < 8 ||
                            input.Length > 15)
                        {
                            Console.WriteLine("INPUTAN TIDAK VALID !!!");
                        }
                        else
                        {
                            checkvalidation = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("INPUTAN TIDAK VALID !!!");
                    }
                }
                else if (inputType.Equals("Email : "))
                {
                    Console.Write(inputType);
                    input = Console.ReadLine();

                    if (!input.Contains("@gmail.com"))
                    {
                        Console.WriteLine("EMAIL TIDAK VALID!!!");
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
