using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(5, 6);
            // Burada class'ın içersindeki metoda ulaşabilmek için o class'ın türünde bir nesne oluşturduk.

            dortIslem.Topla(21, 9);
        }
    }
}
