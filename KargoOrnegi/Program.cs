using System;

namespace KargoOrnegi
{
    class Program
    {
        static void Main(string[] args)
        {
            KargoYonet kargoYonet = new KargoYonet();
            kargoYonet.gonder = new SubeGonder();
            kargoYonet.Add();
            Console.ReadLine();
        }
    }

    class KargoYonet
    {
        public IGonder gonder { get; set; }
        public void Add()
        {
            gonder.Gonder();
        }
    }



    interface IGonder
    {
        void Gonder();
    }

    class AdresGonder : IGonder
    {
    public void Gonder()
        {
            Console.WriteLine("Adrese Gonderildi");
        }
    }

    class SubeGonder : IGonder
    {
        public void Gonder()
        {
            Console.WriteLine("Subeye Gonderildi");
        }

       
    }
}
