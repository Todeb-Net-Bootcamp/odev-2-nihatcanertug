using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public abstract class Instrument
{
    // Enstrüman adında bir soyut sınıf oluşturduk ve her enstrümanda olması gereken özellikleri ortak olarak tanımladık.

    // Id ve Date propertyleri encapsulation ile manipule edilmesi engellendi.
    private Guid _id = Guid.NewGuid();
    public Guid Id
    {
        get { return _id; }
    }

    private DateTime _createDate = DateTime.Now;
    public DateTime CreateDate
    {
        get
        {
            return _createDate;
        }
    }
    public string Brand { get; set; }

    public string Description { get; set; }

    public decimal Price { get; set; }

    public abstract string Play();

}
