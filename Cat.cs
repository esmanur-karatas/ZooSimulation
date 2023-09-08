using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooSimulationx;

namespace ZooSimulation
{
    public class Cat: Animals
    {
        public static List<Cat> Cats { get; set; } = new List<Cat>();

        public static void Add(Cat cat)
        {
            Cats.Add(cat);
        }

        public override string SesCikar() // ses çıkar metodunu ezdik burada çünkü her sınıfta farklı bir ses çıkarıyor.
        {
            return "Miyav!";
        }

        public override string ToString()
        {
            return $"Adı : {Name}, Yaşı : {Age}, Türü : {Species}";
        }
    }
}
