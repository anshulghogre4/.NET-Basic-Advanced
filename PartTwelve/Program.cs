using System.Linq.Expressions;

namespace PartTwelve;

internal class Program
{
    public static void Main(string[] args)
    { //1) example of inheritence and override with virtual keyword
        /*Console.WriteLine("test");

        Animal generic = new Animal(  "minu",  "Meow!",  "anshul" );
        Dog gohan =  new Dog("gohan", "woof!", "anshul", "wooooooooooof!");
        Cat minu = new Cat("minu", "meow!", "anshul", "meowwwwwwwwwww!");

        generic.MakesSound();
        gohan.MakesSound();
        minu.MakesSound();

        Animal.AnimalHealth animalHealth = new Animal.AnimalHealth();
        animalHealth.HealthyWeight(24, 30);
        Console.WriteLine($"is animal healthy {animalHealth.HealthyWeight(.85, 30)}");*/

        //2) example of abstract and polymorphism

        Shape[] shapes = { new Circle(5), new Rectangle(4, 5) };
        foreach (Shape s in shapes)
        {
            s.GetInfo();
            Console.WriteLine($"{s.Name} Area is {s.area()}");
            Circle testCirc = s as Circle;
            if (testCirc == null)
            {
                Console.WriteLine("this isn;t a circle");
            }
            else if (s is Circle)
            {
                Console.WriteLine($"This is not a Rectangle");
            }

            object circ1 = new Circle(4);
            Circle c2 = (Circle)circ1;
            Console.WriteLine($"{c2.Name}'s area is {c2.area()}");
            Rectangle testRec = s as Rectangle;
            if (testCirc == null)
            {
                Console.WriteLine("this isn;t a circle");
            }

        }
    }
}