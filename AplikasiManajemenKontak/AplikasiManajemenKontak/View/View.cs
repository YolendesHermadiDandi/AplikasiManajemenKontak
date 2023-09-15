class View
{
    //Menampilkan menu awal contact
   public void vBaseMenu()
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
                Console.Clear();
                break;
            case "2":
                Console.Clear();
                break;
            case "3":
                Console.Clear();
                break;
            case "4":
                Console.Clear();
                break;
            default:
                Console.Clear();
                break;

        }
    }
}