using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Generics;

public class Program
{

    public static void Main(string[] args)
    {

        /* List<Animal> animalList = new List<Animal>();
         List<int> numberList = new List<int>();
         numberList.Add(24);
         animalList.Add(new Animal("daug"));
         animalList.Add(new Animal("paul"));
         animalList.Add(new Animal("Sally"));
         animalList.Insert(1, new Animal("Steve"));
         animalList.RemoveAt(1);
         Console.WriteLine($"Num of animals are {animalList.Count()}");
         foreach (Animal item in animalList)
         {
             Console.WriteLine(item.Name);
         }

         int x = 5, y = 4;
         Animal.GetSum<int>(ref x, ref y);

         string strX = "5", strY = "4";
         Animal.GetSum<string>(ref strX, ref strY);

         Rectangle<int> rec1 = new Rectangle<int>(20, 50);
         Console.WriteLine(rec1.GetArea());
         Rectangle<string> rec2 = new Rectangle<string>("20", "50");
         Console.WriteLine(rec2.GetArea());*/

        //Delegates
        //part 1
        Arithmatic add, sub, addSub;
        add = new Arithmatic(Add);
        sub = new Arithmatic(Substract);
        addSub = add + sub;
        add(10, 10);//calls the add function
        sub(20, 10);//calls the substract function
        addSub(15, 10); //calls both add and substract like above
                        //basicall we call two out puts by calling one method

        /*  //part2 Lambda expressions
          DoubleIt dbl = x => x * 2;
          Console.WriteLine($"10*2 is {dbl(10)}");

          //part 3 where in lambda expressions
          //it checks for the where conditions like sql but with more freedom to customise the output.
          List<int> list = new List<int> { 1, 2, 3, 4, 5 };
          var even = list.Where(a => a % 2 == 0).ToList(); //it'll convert the list output in the required or tested output
          foreach (var item in even)
          {
              Console.WriteLine(item);
          }

          var ranglist = list.Where(x => (x > 2) || (x < 9)).ToList();
          foreach (var item in ranglist)
          {
              Console.WriteLine(item);
          }

          List<int> flipLi = new List<int>();
          int i = 0;
          Random rnd = new Random();
          while (i < 100)
          {
              flipLi.Add(rnd.Next(1, 3));
              i++;
          }
          Console.WriteLine($"Heads: {flipLi.Where(a => a == 1).ToList().Count()}");
          Console.WriteLine($"Tails: {flipLi.Where(a => a == 2).ToList().Count()}");

          var naeList = new List<string> { "Doug", "low", "Jopy", "lola" };
          var sNameList = naeList.Where(x => x.StartsWith("l")).ToList();
          foreach (var item in sNameList)
          {
              Console.WriteLine(item);
          }

          //part 4 select
          //it executes the function on each item on the list
          *//*
           Common Enumerable Methods:  Enumerable means it can be looped through
          Where: Filters a collection based on a condition.
          Select: Projects each element of a collection into a new form.
          First, Last, Single: Retrieve a specific element from the collection.
          Range: Generates a sequence of numbers.
          OrderBy, ThenBy: Sorts elements of a collection.
          Sum, Count, Average: Performs aggregation functions.
           *//*
          var oneToten = new List<int>();
          oneToten.AddRange(Enumerable.Range(1, 10));
          var squares = oneToten.Select(x => x * x).ToList();
          foreach (var item in squares)
          {
              Console.WriteLine(item);
          }

          //zip

          var listOne = new List<int>(new int[] { 1, 3, 4 });
          var listTwo = new List<int>(new int[] { 4, 6, 8 });

          var sumList = listOne.Zip(listTwo);

          foreach (var item in sumList)
          {
              Console.WriteLine(item);
              *//* output:(1, 4)
              (3, 6)
              (4, 8)*//*
          }

          var sumList2 = listOne.Zip(listTwo, (x, y) => x + y).ToList();
          //basically Zip merge two lists value and it canbe modified 
          foreach (var item in sumList2)
          {
              Console.WriteLine(item);
              *//*Outpur:
               1 + 5 =5
              3+6 =9
              4+8 =12

              means 5
                    9
                    12
               *//*


          }

          //aggreagate
          var numlist2 = new List<int>() { 1, 2, 3, 4, 5, 6 };

          Console.WriteLine($"Sum : {numlist2.Aggregate((a, b) => a + b)}");
          //it sums the values of the list if it's in number type
          Console.WriteLine($"Avg : {numlist2.AsQueryable().Average()}"); // it'll give the average

          //All

          Console.WriteLine($"All >3 : {numlist2.All((x) => x > 3)}"); //check whether all the items are greater than 3 or not
          //Any to check any of the items can be greater than 

          Console.WriteLine($"Any > 3: {numlist2.Any((x) => x > 3)}");

          var numList3 = new List<int>() { 1, 2, 4, 4, 6, 6 };
          var numList4 = new List<int>() { 1, 2, 3, 4, 6, 7 };

          //Distinct to avoid dupicates
          Console.WriteLine($"Distinct: {string.Join(", ", numList3.Distinct())}");

          //except to check any item is missing from another list

          //except
          Console.WriteLine($"Except: {string.Join(", ", numList3.Except(numList4))}");
          //output : no diff as numlist 4 has all the numbers in numlist 3
          // it'll return the difference data which are not matched from two list. here checking numlist 4 with numlist3
          //intersect
          Console.WriteLine($"intersect: {string.Join(", ", numList3.Intersect(numList4))}");
          //it'll show numbers which are presetn in the both of list.
          //here numlist 4 will check what it has common with numlist 3
  */

        //more delegated from gavin lon
        Log log = new Log();

        LogDel LogTextToScreenDel, LogTextToFileDel;

        LogTextToScreenDel = new LogDel(log.LogTextToScreen);

        LogTextToFileDel = new LogDel(log.LogTextToFile);

        LogDel multiLogDel = LogTextToScreenDel + LogTextToFileDel;

        Console.WriteLine("Please enter your name");

        var name = Console.ReadLine();

        LogText(multiLogDel, name);




    }



    public struct Rectangle<T>
    {
        private T width;
        private T length;
        public T Width
        {

            get { return width; }
            set { width = value; }
        }

        public T Length
        {

            get { return length; }
            set { length = value; }
        }

        public Rectangle(T w, T l)
        {
            width = w;
            length = l;
        }
        public string GetArea()
        {
            double dblW = Convert.ToDouble(Width);
            double dblL = Convert.ToDouble(Length);
            return string.Format($"{Width}*{Length} = {dblL * dblW}");

        }
    }

    //Delegates

    
    delegate void LogDel(string text);
    public delegate void Arithmatic(double num1, double num2);
    public delegate double DoubleIt(double x);
    static void LogText(LogDel logDel, string text) //parameter logdel is placed
    {
        //here we're passsing delegates as arguments in the function
        logDel(text);
    }
    public static void Add(double num1, double num2)
    {
        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
    }

    public static void Substract(double num1, double num2)
    {
        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
    }

}

public class Log
{
    public void LogTextToScreen(string text)
    {
        Console.WriteLine($"{DateTime.Now}: {text}");

    }

    public void LogTextToFile(string text)
    {
        using (StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.txt"), true))
        {
            
            sw.WriteLine($"{DateTime.Now}: {text}");
        }

        DirectoryInfo anshulsDir = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.txt"));

        // Get the directory path
        Console.WriteLine(anshulsDir.FullName);
    }
}
