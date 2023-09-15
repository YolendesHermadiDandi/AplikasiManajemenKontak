

namespace AplikasiManajemenKontak.Model
{
    class Kontak
    {

        // constructor
        
        public Kontak() { }
        public Kontak(String id, string name, string phoneNumber, string emailAddress) 
        {
        
            Id = id;
            Name = name;
            PhoneNumber = phoneNumber;
            EmailAddress = emailAddress;

        }

        //setter getter

        public String Id { get; set; }
        public String Name { get; set; }
        public String PhoneNumber { get; set; }
        public String EmailAddress { get; set; }



        // toString buat show all data
        public string toString()
        {
            return "Nama : "+Name+
                    "\nPhone Number : " +PhoneNumber+
                    "\nEmail Address : "+EmailAddress;
        }

    }
}