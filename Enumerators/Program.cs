namespace Enumerators;

public class Program
{
    public static void Main(string[] args)
    {
        AnimalFarm myAnimals = new AnimalFarm();
        myAnimals[0] = new Animal("Wilbur");
        myAnimals[1] = new Animal("Joyeus");
        myAnimals[2] = new Animal("winbown");
        myAnimals[3] = new Animal("Lokeys");

        foreach (Animal item in myAnimals)
        {
            Console.WriteLine(item.Name);
        }

        Box box1 = new Box(2, 4, 6);
        Box box2 = new Box(3, 5, 7);
        Box box3 = box1 + box2;
        Console.WriteLine($"Box 3: {box3.ToString()}");
        Console.WriteLine($"Box 3 int : {(int)box3}");
        Box box4 = (Box)4;

        //anonymous types

        var shopkins = new { Name = "shopkins", Price = 4.99 };
        Console.WriteLine($"sopkiins: {shopkins.Name} with price of {shopkins.Price}");

        var toyArr = new[] {
            new
            {
                Name = "Hotwheels",
                price = 9
            },
            new
            {
                Name = "barbie",
                price = 20
            },
            new
            {
                Name = "Lego",
                price = 30
            },
        };
        foreach (var item in toyArr) {
            Console.WriteLine($"toys: {item.Name} with price of {item.price}");
        }
    }
}