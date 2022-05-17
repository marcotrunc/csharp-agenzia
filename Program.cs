using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp_agenzia;

namespace csharp_agenzia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Appartamento newApp = new Appartamento("sdaad", "via delle Vie 40","00458", "Roma", 100, 5, 2);

            Box newBox = new Box("abcd", "via Villa 38","75022","Milano",40, 3);

            Agenzia az = new Agenzia("Immobiliare");
            az.AddImmobile(newApp);
            az.AddImmobile(newBox);
            

            List<Immobile> results = az.Searchimmobili("5");

            foreach (Immobile m in results)
            {
                Console.WriteLine(m.ToString());
                Console.WriteLine("----------------------------");
            }
            Console.WriteLine("Ho Finito");
        }
    }

}