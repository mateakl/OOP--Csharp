namespace AV1_vjezba
{
    public class Program
    {
        public static void RunSimpleDemoDog()
        {
            Dog dog = new Dog();
            dog.Growl();
            dog.Bark();
        }
        static void Main(string[] args)
        {
            RunSimpleDemoDog();
        }
    }
}
