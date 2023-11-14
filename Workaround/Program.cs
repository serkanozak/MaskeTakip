using System;
using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            Vatandas vatandas1 = new Vatandas();
            vatandas1.Name = "Serkan";
            Console.WriteLine(vatandas1.Name);

            SelamVer("Ayşe");
            SelamVer();


 
            int sonuc = Total(2, 7);
            Console.WriteLine(sonuc);


            List<string> sehirler = new List<string>()
            {
                "Ankara", "Adana", "Denizli" 
            };

            sehirler.Add("Muğla");
            foreach (var sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }


            Person person1 = new Person();
            person1.FirstName = "Serkan";
            person1.LastName = "Özak";
            person1.DateOfBirthYear = 1996;
            person1.NationalIdendity = 123;



            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

        }
        static int Total(int sayi1 = 5, int sayi2 = 3)
        {
            return sayi1 + sayi2;
        }

        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba! " + isim);
        }
    }

    class Vatandas
    {
        private string _name;
        public string Name
        {
            get { return (_name + " Bey"); }
            set { _name = value; }
        }
        public string LastName { get; set; }
    }
}