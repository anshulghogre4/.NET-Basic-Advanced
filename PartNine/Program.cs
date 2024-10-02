using System;
using System.Runtime.InteropServices;

namespace PartNine;

internal class PartNine
{
    public static void Main(string[] args)
    {
        //functions................................................
        TestFunc();

        // examples of out prameters function
        int fullAge = 11;
        //Testing(num: out fullAge)  this is also possible as "fullage" data type is already made
        Testing(num: out int testAge);
        Console.WriteLine(testAge);
        // example for refrernce parameter function
        string lol = "LOL";
        TestingRef(ref fullAge, ref lol);
        Console.WriteLine($"{fullAge} and here is the tex:{lol}" );
        //as you can see in the console it'll change the refrence's value.
        /*in ref para you need to initialize the variable before you can't do like this
        TestingRef(ref int fullAge, ref lol); or 
        TestingRef(ref int fullAge, ref string lol
         */
        Console.ReadLine();

        //access specifier
        //public : Can be accessed from another class
        //private : Can't be accessed from another class;
        //protected : can be accessed by class and derived classes;
    }

    static void TestFunc()
    {

        //Console.WriteLine($"test {Add(5,5)}"); //10
        Console.WriteLine($"test {Add(5)}"); //when 50 is default then output 55 
        //and if default is default then 5 as default is 0
        Printname("Test");
        Printname();
        string fullName = "jojo rascal";
        int fullAge = 59;
        string countryName = "Giant World.";
        PrintDetails(name: fullName, age: fullAge, country: countryName); //named parameters

    }

    //static functions can be accessed directly 
    //for non static function class object need to be initialised

    //function with optional parameter.....................................

    /*static int Add(int x, int y=50) { 
        //here 50 is default value
        return x + y;
    }*/

    /* static int Add(int x, int y = default) //prefer this
     {
         //here 50 is default value
         return x + y;
     }*/
    static int Add(int x, [Optional] int y)
    {
        //here 50 is default value
        Console.WriteLine($"y value is {y}"); //it'll be 0

        return x + y;
    }


    //for string default values will be empty string
    /* static void Printname([Optional] string? name)
     {
         Console.WriteLine($"my name is {name}");
     }*/
    static void Printname(string? name = default)
    {
        Console.WriteLine($"my name is {name}");
    }

    //function with named parameter............................

    static void PrintDetails(string name, int age, string country)
    {
        Console.WriteLine($"name is {name}");
        Console.WriteLine($"age is {age}");
        Console.WriteLine($"country is {country}");

    }

    //function with out parameters.....................................

    public static void Testing(out int num)
    {
        num = 444;
    }

    // Function with Refrence parameter

    static void TestingRef(ref int cool, ref string name)
    {
        cool = 4619; //here it'll change value of the reference
        //in out parameter function , it should be assigned inside the function
        name = "Jaskier";

    }
}
