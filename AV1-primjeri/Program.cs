namespace AV1_primjeri
{
    public class Program
    {
        public static void RunSimpleDemoDog()
        {
            Dog dog = new Dog();
            Console.WriteLine(dog.Growl());
            Console.WriteLine(dog.Bark());
        }
        public static void RunSimpleDemoBook()
        {
            Book book = new Book();
            book.Author = "Sanja Pilic";
            book.Title = "Dnevnik Pauline P";
            book.NumberOfPages = 263;
            Console.WriteLine($"This book is {book.Author} : {book.Title}, ({book.NumberOfPages})");

        }

        public static void RunSimpleDemoRectangle()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Width = 3.2f;
            rectangle.Height = 5.5f;
            rectangle.GetDescription();
            rectangle.Scale(2);
            rectangle.GetDescription();

        }

        public static void RunSimpleDemoReceipt()
        {
            Receipt receipt = new Receipt();
            receipt.Id = "fj645i4h";
            receipt.Price = 234.56m;
            receipt.Tax = 75;
            Console.WriteLine($"Price: {receipt.Price}");
            Console.WriteLine($"Your total before sale: {receipt.GetTotal()}\n");
            Console.WriteLine($"Your total after the sale: {receipt.GetSale(75)}");

        }
        public static void RunSimpleDemoDamage()
        {
            Damage pipisDamage = new Damage(400f, 505.7f, 231.45f);
            Defense pipisDefense = new Defense(0.75f, 0.55f);
            Character pipi = new Character("Pipi", pipisDamage, pipisDefense, 1000);
            Console.WriteLine($"A new character has just spawned *-.,_,.-* WOOSH {pipi.Name} :3 Nyan! Nyan!\n");
            Console.WriteLine($"This is pipis health: " + pipi.Health + "\n");
            Console.WriteLine(pipi.TakeDamage(pipisDamage));
            Console.WriteLine($"\nWOAAH! Pipi has taken some damage :/. She now has {pipi.Health} health. She has to fight of this intruder\n");
            Console.WriteLine($"Who is this intruder you ask yourself...\n");
            Damage pablosDamage = new Damage(500f, 560f, 342.45f);
            Defense pablosDefense = new Defense(0.35f, 0.66f);
            Character pablo = new Character("Pablo", pablosDamage, pablosDefense, 1000);
            Console.WriteLine($"It is the GREAAT~ ~ ~ {pablo.Name}\n");
            Console.WriteLine("this is pablos health: " + pablo.Health + "\n");
            Console.WriteLine($"Looks like {pipi.Name} is ready to attack!\n");
            Console.WriteLine(pablo.TakeDamage(pablosDamage));
            Console.WriteLine($"\nOOOH, look at that damage! Pablo now has {pablo.Health} health\n");
            Console.WriteLine($"Looks like {pipi.Name} is attacking AGAIN! BUT IT CANT BE!\n");
            Console.WriteLine($"{pipi.Name} is doing tha FART ATTACK!");
            Console.WriteLine("KAPOOOOF! PRNEEEM PONEKAD LJUBAVI PRNEEEM!");
        }
            
        static void Main(string[] args)
        {
            //RunSimpleDemoDog();
            //RunSimpleDemoBook();
            //RunSimpleDemoRectangle();
            //RunSimpleDemoReceipt();
            RunSimpleDemoDamage();
        }
    }
}
