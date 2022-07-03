using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
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
