namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car()
            {
                Make = "Toyota",
                Model = "Corolla",
                Year = 2003
            };

            Console.WriteLine("This is the Make, Model, & Year of my car:");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"{myCar.Make} {myCar.Model} {myCar.Year}");
        }
    }
}
