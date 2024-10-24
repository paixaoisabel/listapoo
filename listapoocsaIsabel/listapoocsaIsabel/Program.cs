


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listapoocsaIsabel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Area ar;
            ar = new Area();

            Console.Write("Digite o valor da base: ");
            ar.setbase(int.Parse(Console.ReadLine()));

            Console.Write("Digite o valor da altura: ");
            ar.setaltura(int.Parse(Console.ReadLine()));

            ar.calcularArea();

            Console.WriteLine("O valor da area é de: {0}",ar.getarea());

        }
    }
}
