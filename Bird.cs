using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooSimulationx;

namespace ZooSimulation
{
    public class Bird : Animals // Animal sınıfından kalıtım aldık.
    {
        public static List<Bird> Birds { get; set; } = new List<Bird>();

        public static void Add(Bird bird)
        {
            Birds.Add(bird);
        }

        internal static void Add(Cat cat)
        {
            throw new NotImplementedException();
        }

        public override string SesCikar()// ses çıkar metodunu ezdik burada çünkü her sınıfta farklı bir ses çıkarıyor.
        {
            return "Cik Cik!";
        }

        public override string ToString()
        {
            return $"Adı : {Name}, Yaşı : {Age}, Türü : {Species}";
        }
    }
}
       
          