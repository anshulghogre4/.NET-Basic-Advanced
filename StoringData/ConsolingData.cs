
namespace StoringData;

internal class ConsolingData
{
    public static void Main(string[] args)
    {
        /*Console.WriteLine("enter your name" );*/
        Console.Write("enter your name: ");
        //Console.Write
        string name = Console.ReadLine();
        Console.WriteLine(name);

        Console.Write("enter your age: ");
        string age = Console.ReadLine();
        Console.WriteLine("your name is "+ name +  " and the age is " + age);

        Console.ReadLine();
    }
}