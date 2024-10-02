namespace parttwooperatos
{
    internal class ProgramOperators
    {
        static void Main(string[] args)
        {
            //operators
            //+-*/ with numbers
            int age = 23;
            age++; // age  +1 and age += these are all same
            age = age + 10;
            age += 10;
            Console.WriteLine(age);
            age -= 10;
            Console.WriteLine(age);
            age *= 10;
            Console.WriteLine(age);
            age /= 10; //will return the integer therefore whenever we do division
            Console.WriteLine(age);
            age--;
            Console.WriteLine(age);
            // for decimal places we can use double
            double ageDouble = 23;
            ageDouble /= 10;
            Console.WriteLine(ageDouble);


            //opertators with string

            string name = "test ";
            name += "is waiting to get tested";
            // we can not use - in string as it's not built in the language
            Console.WriteLine(name);

            //operators in the chars now
            char ch ='a';
            Console.WriteLine(ch);
            ch += 'b';
            // avoid character concatination
            Console.WriteLine(ch);
            int i =0;
            Console.WriteLine(i++); //here it'll return the value of i first then it'll later increase the number 
            //as in this case output would be 0;
            //however if it's ++i then it'' first increase the number b 1 then it'll return the value of the i
            //the it's value is 1 initially.


            // reaminder

            int fistNum = 10;
            int secNum = 2; //used to define wehther to check for 

            Console.WriteLine(fistNum/secNum); // output will be 3 as it's getting divided 1 is remainder here
            Console.WriteLine(fistNum % secNum); // output:remainder as 1
            //for even odd if the value is o then it's eeven else odd.

            Console.ReadLine();


        }
    }

}

