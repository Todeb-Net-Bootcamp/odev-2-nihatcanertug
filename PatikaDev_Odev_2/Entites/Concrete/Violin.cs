using PatikaDev_Odev_2.Entites.Abstract;
using System;

namespace PatikaDev_Odev_2.Entites.Concrete
{

    public class Violin : Instrument
    {
        //Keman sınıfı soyut enstrüman sınıfından kalıtım alarak zorunlu tuttugumuz ilgili methodu override etti.
        public override string Play()
        {
            return "Violin voice";
        }
    }
}