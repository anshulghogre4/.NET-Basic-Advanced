using System.Globalization;

namespace Statements;

internal class  Statements {


    public static void Main(string[] args) {
        //if else statements 
        //switch
        //for loops
        //while
        //do -while
        //? operastor or ternary operator

        //numeric formatting

        double val = 100D / 12.34D; // this will give the number digits afer decimals
        Console.WriteLine(val);
        Console.WriteLine(string.Format("{0:0.0}",val));
        Console.WriteLine(string.Format("{0:0.0}", val));
        Console.WriteLine(string.Format("{0:0.#}", val));
        Console.WriteLine(string.Format("{0:0.00}", val));
        double money = -10D / 3D; //3.3333333
        Console.WriteLine(money);
        Console.WriteLine(string.Format("-$10/ $3 = ${0:0.00}", money)); //3.33
        Console.WriteLine(money.ToString("C")); // "C" foramt secifies reresents currency 
        Console.WriteLine(money.ToString("C0")); 
        Console.WriteLine(money.ToString("C1"));
        Console.WriteLine(money.ToString("C2"));
        Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));  // "C" foramt secifies reresents currency 
        Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-GB"))); // "C" foramt secifies reresents currency  -$3.33
        Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))); // "C"  ($3.33)
        Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-AU"))); // "C"  -$3.33


        Console.ReadLine();




    }
}
