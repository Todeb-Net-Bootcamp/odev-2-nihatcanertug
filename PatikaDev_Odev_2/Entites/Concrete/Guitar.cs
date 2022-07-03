using System;


public class Guitar : Instrument
{
    //Gitar sınıfı soyut enstrüman sınıfından kalıtım alarak zorunlu tuttugumuz ilgili methodu override etti.
    public override string Play()
    {
        return "Guitar voice";
    }
}
