using PatikaDev_Odev_2.Entites.Abstract;
using System;
using System.Collections.Generic;

namespace PatikaDev_Odev_2.Entites.Concrete
{

    public class Musician
    {
        public List<Instrument> Instruments { get; set; }

        //Contructor method,ilgili müzisyen sınıfı başlatıldığında otomatik olarak çağırılarak enstrüman listesini oluşturacaktır.
        public Musician()
        {
            Instruments = new List<Instrument>();
        }

        //Müzisyen sınıfının property'leri aşağıda tanımlanmıştır.
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }
}