using System.Runtime.InteropServices;
using System.Threading.Channels;

namespace PartSix;

internal class PartSix
{
    public static void Main(string[] args)
    {
        //1) Try parse function........................................................
        /* Console.WriteLine("enter a number");
         string numInut = Console.ReadLine(); // 10p will result an error.
         //int num = Convert.ToInt32(numInut);

         // if in input if we type something "10p" isntead of 10 then there will be an error 
         //therefore to deal with it we use  tryparse function
         // if I try to type input as "6e" now it'll give me num as 0 instead of an exception here
         bool success =  int.TryParse(numInut, out int num);
         if (success)
         {
             Console.WriteLine(num);
         }
         else
         {
             Console.WriteLine("failed to convert.");
         }
         Console.WriteLine();*/

        //2)Verbatim String literal(@).....................................................


        /*
         in C# if string contains a "\" backslash then you have to write double backslash
        "\\" like this beacuse \ is C# is designated character
        e.g. "C:\\Users\\Anshul.g\\calc

        some escape cahracters are
        "\t \n \"
        
         */

        /*string path = "C:\\Users\\Anshul.g\\calc";
        //suppose you want to add a speech marks inside the speech mark;
        string speech = "he said \"Somethiong is coming!!\" \n then I was in shocking state \t but it wass okay." ;

        Console.WriteLine(path);
        Console.WriteLine(speech);

        // to negate the escape character we use "@" symbol
        //however you can not use the \n\t or \ in this way other wise it'll take the string as it s.
        path = @"C:\Users\Anshul.g\calc" + "\n  checking it lol"; //but can be done like this
        Console.WriteLine(path);
        // "${}" string interpolation and + is used in string for concatination;
        Console.WriteLine($"testing {speech}");

        string withVerbatim = @"testing speech mark inside speech mark ""yes it's working!!""";
        // need to include ""xyz"" double quote 2 times for to pring quote inside it.
        Console.WriteLine(withVerbatim);*/

        // 3)string formating ({0})...............................................
       /* string name = "ansh";
        int age = 29;

        Console.WriteLine("your name is " + name + ", yourt age is " + age);
        Console.WriteLine("your name is {0}, yourt age is {1}", name, age);

        //"${}" string interpolation
        Console.WriteLine($"your name is {name}, yourt age is {age}");

        // string concatination with inbulit function.
        string test = string.Concat("your name is ", name, " and your age is ", age);
        Console.WriteLine(test);*/

        //4)empty string.....................................................................

        string str = string.Empty; // is equal to "" this empty string;
                                   // string.Empty will be used in conditions like if else

        // 5) string equals function.......................................

        //to check if one string is equal to another string then we can use this
        // "==" and .Equals are different  because equals will check from reference int he memory,
        /*
        string msg = "hello";
        string comp = "hello";
        if (msg.Equals(comp))
        {
            Console.WriteLine("same");
        }
        else
        {
            Console.WriteLine("notsame");
        }

        char[] chars = new char[] { 'h', 'e', 'l', 'l', 'o' };
        object newComp = new string(chars);
        // here msg ==  newComp wont work as it's comparing it from the memory
        // also as you can see msg is type of string while the neComp is type of obj

        if (msg.Equals(newComp))
        {
            Console.WriteLine("same same");
        }
        else
        {
            Console.WriteLine("notsame not same");
        }
        */


        //6) string iteration........................................................................
        //string message = "C# is awesome";
        string message = null;

        /* Console.WriteLine(message[0]);//C
         Console.WriteLine(message[1]);//#
         Console.WriteLine(message[2]); //*/
        /*  for (int i = 0; i < message.Length; i++)
          {
              Console.Write(message[i]);
              //taking it from System.Threading
              Thread.Sleep(150); // this thread will sleep for a 150ms and it'll pring on the command line like aanimation
          }
          Console.WriteLine();

          //.Contains function 
          Console.WriteLine(message.Contains("C"));*/


        // string isNullOrEmpty function...............................................................
        // this one is effective than the isEmpty function
        if (!string.IsNullOrEmpty(message))
        {
            Console.WriteLine("string is right");
        }
        Console.ReadLine();
    }
}