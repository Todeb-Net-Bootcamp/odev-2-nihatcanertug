using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Violin : Instrument
{
    //Keman sınıfı soyut enstrüman sınıfından kalıtım alarak zorunlu tuttugumuz ilgili methodu override etti.
    public override string Play()
    {
        return "Violin voice";
    }
}
