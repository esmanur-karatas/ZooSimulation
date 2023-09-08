using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooSimulationx;


namespace ZooSimulation
{
    public class Dog : Animals
    {
        public static List<Dog> Dogs { get; set; } = new List<Dog>();

        public static void Add(Dog dog)
        {
            Dogs.Add(dog);
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
