﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle( Musteri musteri)

        {
            Console.WriteLine("Müşteri Eklendi :"+ " "+musteri.Adi + "  " + musteri.Soyadı);
        }

        public void Sil(Musteri musteri)

        {
            Console.WriteLine("Müşteri Silindi :"+ " "+musteri.Adi + "  " + musteri.Soyadı);
        }

        public void Listele(Musteri musteri)

        {
            Console.WriteLine("Müşteri Listelendi: " + musteri.Adi+ "  " + musteri.Soyadı);
        }

        
    }
}
