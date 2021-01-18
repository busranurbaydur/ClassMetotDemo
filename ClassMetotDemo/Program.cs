using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1011;
            musteri1.Adi = "Büşranur";
            musteri1.Soyadı = "Baydur";
            musteri1.Tc = "10000000000";
            musteri1.TelNo = 5552227744;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 1111;
            musteri2.Adi = "Hasan";
            musteri2.Soyadı = "Can";
            musteri2.Tc = "11000000000";
            musteri2.TelNo = 5550000000;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 1001;
            musteri3.Adi = "Ali";
            musteri3.Soyadı = "Demir";
            musteri3.Tc = "11100000000";
            musteri3.TelNo = 5555000000;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 1000;
            musteri4.Adi = "Ayşe";
            musteri4.Soyadı = "Kaya";
            musteri4.Tc = "11110000000";
            musteri4.TelNo = 5555500000;


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            foreach (var musteri in musteriler)

            {
                Console.WriteLine("Müşteri Numarası :" + musteri.Id );

                Console.WriteLine("Müşteri Adı Soyadı :"+"  "+musteri.Adi +"  "+musteri.Soyadı);

                Console.WriteLine("Müşteri Tc Kimlik No :"+"  "+musteri.Tc);

                Console.WriteLine("Müşteri Telefon Numarası :"+"  "+musteri.TelNo);

                Console.WriteLine("                                              ");
            }

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Listele(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);
            


        }
    }
}
