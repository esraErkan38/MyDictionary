using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string, int> UlkeBarkod = new MyList<string, int>();
            UlkeBarkod.Add("Türkiye", 868 );
            UlkeBarkod.Add("Güney Kıbrıs", 529);
            UlkeBarkod.Add("Karadağ", 389);
            UlkeBarkod.Add("Azerbaycan", 476);
            UlkeBarkod.Add("Türkmenistan", 483);
        }
    }
}
