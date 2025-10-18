using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV1_primjeri
{
    public class Dog
    {
        public string name = "Cirko";
        public string breed = "Doberman";
        public string colour = "Black";
        public string id = "HR94859CD";
        public string Growl()
        {
            return "Grrr!";
        }
        public string Bark()
        {
            return Growl() + $"Woof! Woof! I am {name} - {breed} - {colour} - {id}";
        }
    }
}
