using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ZooSimulation
{
    abstract class Animals
    {
        private List<Animals> animals = new List<Animals>();

        public void AddAnimal(Animals animal)
        {
            animals.Add(animal);
        }
        public string Name { get; set; } // başka sınıflardada da kullanabilmek için public erişim belirtecini kullandık. ve çağırmak ve kullanmak için get set tanımladık
        public string Species { get; set; }
        public string Age { get; set; }

        public abstract string SesCikar(); //metot oluşturduk. ses çıkar metodunu başka sınıflarda ezeceğimiz için boşa değer döndürmedik

    }
        
}

