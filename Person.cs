// See https://aka.ms/new-console-template for more information
namespace latihan4
{
    public class Person
    {
        public string Name {get; set;}

        public void Greet()
        {
            Console.WriteLine($"Hello, My Name is {Name}");
        }
    }
}