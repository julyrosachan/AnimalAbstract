namespace Test;
class Program
{
    static void Main()
    {
        Animal[] animals = new Animal[]
        {
            new Dog(),
            new Cat(),
        };

        foreach (Animal a in animals)
        {
            Console.WriteLine(a.Speak());
        }
    }
}