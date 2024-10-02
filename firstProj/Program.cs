using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello World");

            //data types
            //numbers
            /*int age = 23;
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            long bigNum = 99999999L;
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            double doubNum = -55.5D; //can take upto 15-16 digits after decimal
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);
            float recision = 5.0001F; // can upt 7 digits of precision
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);
            decimal mon = 14.99M; //can take upto 28-29 digits after decimal
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);
            */

            //text based data types
            string name = "Test"; // here '' not used as it's used in chars
            char letters = 'A';
            /* double quotes are used for string and single quotes are used for chars otherwise it'll give the
            error*/



            //converting string to numbers
            /*string textAge = "-23";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age);

            string textBigNum = "-99999999";
            long bigNum = Convert.ToInt64(textBigNum);
            Console.WriteLine(bigNum);
            string textNegDouble = "-55.2";
            double doubNum = Convert.ToDouble(textNegDouble); //can take upto 15-16 digits after decimal
            Console.WriteLine(doubNum);
            string textFloatNum = "-5.0000012";
            float recision = Convert.ToSingle(textFloatNum); // can upt 7 digits of precision
            Console.WriteLine(recision);
            string textNumMon = "-14.999999999999999";
            decimal mon = Convert.ToDecimal(textNumMon); //can take upto 28-29 digits after decimal
            Console.WriteLine(mon);*/

            //boolean data types

            bool val = true;
            Console.ReadLine();
        }
    }
}
