using System.Xml.Linq;
using AplikasiManajemenKontak.Controller;

namespace AplikasiManajemenKontak.View
{


    class View
    {
        //Menampilkan menu awal contact
        public static void vBaseMenu()
        {
            bool program = true;
            while (program)
            {
                Console.Clear();
                Console.WriteLine("=== Manage Contact ===");
                Console.WriteLine("1. Create Contact");
                Console.WriteLine("2. Edit Contact");
                Console.WriteLine("3. Show Contact");
                Console.WriteLine("4. Exit");

                //Membuat selectin pilihan menu
                Console.Write("Select : ");
                string select = Console.ReadLine();
                switch (select)
                {
                    case "1":
                        //Console.Clear();
                        //Console.WriteLine("=== Create Contact Person ===");
                        //Console.Write("Nama             : ");
                        //string name = Console.ReadLine();
                        //Console.Write("Number Phone     : ");
                        //string phoneNumber = Console.ReadLine();
                        //Console.Write("Email Address    : ");
                        //string email = Console.ReadLine();
                        //VVV masukan code untuk memasukan data kedalam list yang telah di buat VVV
                        KontakController.CreateKontak();
                        break;
                    case "2":
                        Console.Clear();
                        vEditContact();
                        break;
                    case "3":
                        Console.Clear();
                        vShowContact();
                        break;
                    case "4":
                        Console.Clear();
                        program = false;
                        break;
                    default:
                        Console.WriteLine("Sorry your selection program is invalid!!!");
                        Console.ReadKey();
                        break;

                }
            }

        }

        public static void vEditContact()
        {
            bool program = true;

            while (program)
            
            {
                Console.Clear();
                KontakController.ShowAllKontak();
                Console.WriteLine("=== Edit Contact ===");
                Console.WriteLine("1. Update Contact");
                Console.WriteLine("2. Delete Contact");
                Console.WriteLine("3. Back");
                //Membuat selectin pilihan pada menu edit
                Console.Write("Select : ");
                string select = Console.ReadLine();
                switch (select)
                {
                    case "1":
                        Console.Write("Nama             : ");
                        string name = Console.ReadLine();
                        Console.Write("Number Phone     : ");
                        string phoneNumber = Console.ReadLine();
                        Console.Write("Email Address    : ");
                        string email = Console.ReadLine();
                        //VVV masukan code untuk memasukan data kedalam list yang telah di buat VVV

                        break;
                    case "2":
                        Console.Write("Select ID Contact    : ");
                        string idContact = Console.ReadLine();
                        //VVV Masukan code untuk menghapus contact VVV

                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        program = false;
                        break;
                    default:
                        Console.WriteLine("Sorry your selection program is invalid!!!");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public static void vShowContact()
        {
            bool program = true;
            while (program)
            {
                Console.Clear();
                Console.WriteLine("=== Show Contact ===");
                KontakController.ShowAllKontak();

                //Untuk Menampilkan seluruh isi kontak
                /*foreach (UserData userData in UserDatas)
                {
                    Console.WriteLine("========================");
                    Console.WriteLine("Name         : " + userData.id);
                    Console.WriteLine("Phone Number : " + userData.firstName + " " + userData.lastName);
                    Console.WriteLine("Email        : " + userData.username);
                    Console.WriteLine("========================");
                }*/

                Console.WriteLine("\n1. Search Contact");
                Console.WriteLine("2. Back");
                //Membuat selectin pilihan pada menu show
                Console.Write("Select : ");
                string select = Console.ReadLine();
                switch (select)
                {
                    case "1":
                        Console.Write("Please write Name / Phone number / Email Address :");
                        string search = Console.ReadLine();
                        // VVV masukan code untuk mencari contact VVV
                        /*foreach (var item in UserDatas)
                        {
                            if (item.firstName.Contains(name) || item.lastName.Contains(name))
                            {
                                Console.WriteLine("========================");
                                Console.WriteLine("ID       : " + item.id);
                                Console.WriteLine("Name     : " + item.firstName + " " + item.lastName);
                                Console.WriteLine("Username : " + item.username);
                                Console.WriteLine("Password : " + item.password);
                                Console.WriteLine("========================");
                                count++;
                            }
                        }*/

                        break;
                    case "2":
                        Console.Clear();
                        program = false;
                        break;
                    default:
                        Console.WriteLine("Sorry your selection program is invalid!!!");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public void vHistoryContact()
        {
            bool program = true;
            while (program)
            {
                Console.WriteLine("=== Show History Contact ===");

                //Untuk Menampilkan seluruh isi kontak
                /*foreach (UserData userData in UserDatas)
                {
                    Console.WriteLine("========================");
                    Console.WriteLine("Name         : " + userData.id);
                    Console.WriteLine("Phone Number : " + userData.firstName + " " + userData.lastName);
                    Console.WriteLine("Email        : " + userData.username);
                    Console.WriteLine("========================");
                }*/
                Console.WriteLine("1. Search Contact");
                Console.WriteLine("2. Back");
                //Membuat selectin pilihan pada menu show
                Console.Write("Select : ");
                string select = Console.ReadLine();
                switch (select)
                {
                    case "1":
                        Console.Write("Please write Name / Phone number / Email Address :");
                        string search = Console.ReadLine();
                        // VVV masukan code untuk mencari contact VVV
                        /*foreach (var item in UserDatas)
                        {
                            if (item.firstName.Contains(name) || item.lastName.Contains(name))
                            {
                                Console.WriteLine("========================");
                                Console.WriteLine("ID       : " + item.id);
                                Console.WriteLine("Name     : " + item.firstName + " " + item.lastName);
                                Console.WriteLine("Username : " + item.username);
                                Console.WriteLine("Password : " + item.password);
                                Console.WriteLine("========================");
                                count++;
                            }
                        }*/

                        break;
                    case "2":
                        Console.Clear();
                        program = false;
                        break;
                    default:
                        Console.WriteLine("Sorry your selection program is invalid!!!");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}