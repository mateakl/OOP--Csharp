using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AV1_primjeri
{
    public class Damage
    {
        public float Physical { get; private set; }
        public float Magical { get; private set; }
        public float True { get; private set; }
        public Damage(float physical, float magical, float True)
        {
            this.Physical = physical;
            this.Magical = magical;
            this.True = True;
        }
        public float TotalDamage()
        {
            return Physical + Magical + True;
        }
    }

    public class Defense
    {
        public float PhysicalDefense { get; private set; }
        public float MagicalDefense { get; private set; }
        public Defense(float physicalDefense, float magicalDefense)
        {
            if (physicalDefense < 0.0f)
            {
                physicalDefense = 0.0f;
            }
            else if (physicalDefense > 1.0f)
            {
                physicalDefense = 1.0f;
            }
            if (magicalDefense < 0.0f)
            {
                magicalDefense = 0.0f;
            }
            else if (magicalDefense > 1.0f)
            {
                magicalDefense = 1.0f;
            }
            this.PhysicalDefense = physicalDefense;
            this.MagicalDefense = magicalDefense;
        }
    }

    public class Character
    {
        public string Name { get; private set; }
        public Damage Damage { get; private set; }
        public Defense Defense { get; private set; }
        public float Health {  get; private set; }  

        public Character(string Name, Damage Damage, Defense Defense, float Health)
        {
            this.Name = Name;
            this.Damage = Damage;
            this.Defense = Defense;
            this.Health = Health;
     
        }
        public float TakeDamage(Damage damage)
        {
            float totalPhysicial = damage.Physical * (1 - Defense.PhysicalDefense);
            float totalMagical = damage.Magical * (1 -Defense.MagicalDefense);
            float totalTrue = damage.True;
            float total = totalPhysicial + totalMagical + totalTrue;
            Health -= total;
            Console.WriteLine(Name + " suffers damage( Physicial: " + totalPhysicial + " | Magical: " + totalMagical + " | True: " + totalTrue + ")\nAnd total: ");
            return total;
        }

    }


}
