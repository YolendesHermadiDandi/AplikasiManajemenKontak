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


            Kontak kontak = new Kontak();   
            return kontak;
    
          
        }

        private static String InputCheck(String inputType)
        {
            return "asas";

        }
    }
}
