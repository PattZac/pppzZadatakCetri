using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pppzZadatakCetri
{
    class KlasuX
    {
        private int broj;
        public int Broj { get => broj; set => broj = value; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            KlasuX x = new KlasuX();
            x.Broj = 10;
            Console.WriteLine(x.Broj);
            Console.ReadKey();
        }
    }
}
