// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

namespace keywordprog;
internal class KeywordProg
{
    static void Main(string[] args)
    {
        //var keyword
        // here compiler will decide the type of the variable with it's initialised value.

        var age = 23; //compiler gets to know that it's type of int32
        var bigNum = 99999999L;
        var doubNum = -55.5D; //can take upto 15-16 digits after decimal
        var recision = 5.0001F; // can upt 7 digits of precision
        var mon = 14.99M; //can take upto 28-29 digits after decimal
        var naem = "test";
        var cha = 'a';

        //const key word

        //as you already know const's variable's value do not change one initialised.
        const int val = 123;
        const double percentVat = val/100D;
        int balance = 1000;
        const string version = "1.0.0";
        Console.WriteLine(balance*percentVat);
        Console.ReadLine();

    }
}

