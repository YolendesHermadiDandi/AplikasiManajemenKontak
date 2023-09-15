

namespace AplikasiManajemenKontak.Model
{
    class Kontak
    {
        public Kontak() { }
        public Kontak(String id, string name, string phoneNumber, string emailAddress) 
        {
        
            Id = id;
            Name = name;
            PhoneNumber = phoneNumber;
            EmailAddress = emailAddress;

        }

        public String Id { get; set; }
        public String Name { get; set; }
        public String PhoneNumber { get; set; }
        public String EmailAddress { get; set; }


        public string toString()
        {
            return "Nama : "+Name+
                    "\nPhone Number : " +PhoneNumber+
                    "\nEmail Address : "+EmailAddress;
        }

    }
}