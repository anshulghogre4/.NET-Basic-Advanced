namespace PartSeven;
internal class PartSeven
{
    public static void Main(string[] args)
    {
        //arrays..........................................................
        int[] numbers = new int[] { 1, 0, 4, 3, 5, 9, 1, 8, 9 }; // array of integers with 3 positions

        //array sorting.......................................
        /* Array.Sort(numbers);*/
        /* foreach (var item in numbers) //it's being used for going in every case
         {
             Console.WriteLine(item);
         }*/

        //array reversal.......................................
        /*  Array.Reverse(numbers);*/
        /*foreach (var item in numbers) //it's being used for going in every case
        {
            Console.WriteLine(item);
        }*/
        //array clearing.......................................

        /* //Array.Clear(numbers); it'll clear the content in the array
         //Array.Clear(numbers,0, numbers.Length); it'll clear th content from 0 to total length
         Array.Clear(numbers);
         // it'll assign all the values to 0 based on data type.
         // default keyword will be used for showing or assigning default value based on the data type
         for (int i = 5; i < numbers.Length; i++) //it's the manual way of  Array.Clear(numbers,5, 5)
         {
             numbers[i] = default;
         }
         foreach (var item in numbers)
         {
             Console.WriteLine(item);
         }*/

        //array indexOf
        Console.WriteLine("enter th number for search");
        /* int searcheDnUM = Convert.ToInt32(Console.ReadLine());
         var val = Array.IndexOf(numbers, searcheDnUM);
         if (val != -1) { Console.WriteLine("all good"); }*/
        int searcheDnUM = Convert.ToInt32(Console.ReadLine());
      /*  var val = Array.IndexOf(numbers, searcheDnUM);
        if (val != -1) { Console.WriteLine("all good"); }*/
        var valNew = Array.IndexOf(numbers, searcheDnUM,1); //can place start index in this function
        var val = Array.IndexOf(numbers, searcheDnUM);
        if (val != -1) { Console.WriteLine("all good"); }

        Console.ReadLine();
    }
}
