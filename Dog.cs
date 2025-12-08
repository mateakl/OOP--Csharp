using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV1_vjezba
{
    public class Dog
    {
        public string name = "Cirko";
        public string breed = "Doberman" ;
        public string color = "Black";
        public string identificator = "HR86928DC";


        public string Growl()
        {
            return $"Grrrr!";
        }
        public string Bark()
        {
            return Growl() + $"Woof! Woof! I am {name} - {breed} - {color} - {identificator}";
        }
    }
}
