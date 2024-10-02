namespace PartEight;
internal class PartEight
{
    public static void Main(string[] args)
    {
      // 1) lists<> in list you can increase the data and decrese the data dyanamically unlike array
       // it doesnot contain key value pair but dictionary does.

        List<int> listNumbers = new List<int>(); //we can add the capacity as well here
        listNumbers.Add(1);
        listNumbers.Add(2);
        listNumbers.Add(3);

        // HERE listNumbers.Add(3); ADDS the 3 at the end of the list while listNumbers.insert(3);
        /*for (int i = 0; i < listNumbers.Count; i++)
        {
            Console.WriteLine(listNumbers[i]);
        }*/

        /*foreach (var item in listNumbers)
        {
            Console.WriteLine(item);
        }*/
        //listNumbers.Clear();  removes all elements from the list
        /*
                listNumbers.EnsureCapacity(4);
                listNumbers.Insert(3, 4); //it'll insert at the spcifc position
                //listNumbers.FindIndex(3, listNumbers.Count,);// we can get index from here
                listNumbers.RemoveAt(3); // it'll remove the specific position
                listNumbers.ForEach((x) => Console.WriteLine(x));
                Console.WriteLine(listNumbers.Capacity);
                Console.WriteLine(listNumbers.ToArray());
                Console.WriteLine(listNumbers.ToString());*/

        //2) Dictionary
        // note: key mustbe unqiue and cannot be null whereas value can be null 
        //and can be duplicated.
        /* Dictionary<int, string> names = new Dictionary<int, string>
         {
             //key value pair
             { 2, "ansh" },
             { 1, "test" },
             { 3, "tust" }
         };

         for (int i = 0; i < names.Count; i++)
         {
             KeyValuePair<int, string> pair = names.ElementAt(i);
             Console.WriteLine($"par key {pair.Key} and its value is {pair.Value}");
         }
         // for loop here is complicate a bit better use foreach
         // because it return type of  KeyValuePair<int, string> pair
         foreach (var item in names)
         {
              Console.WriteLine($"par key {item.Key} and its value is {item.Value}");

         }*/
        Dictionary<string, string> coutries = new()
        {
            { "India", "Best culture diversity" },
            { "Dubai", "rich peoples choice" }
        };
        //if dictionary contains the key then TryGetValue returns the true otherwise it'll give false
        //if it's true then it'll return the value associated with this.

        if (coutries.TryGetValue("India", out var val)) //this will not throw any exception
        {
            Console.WriteLine(val);
                /*
                 We can change the assigned key's value here if we want
                 */

        }
        //some other methods of dictionary.
        //to remove the key and value we better check whether that key is present or not

        if (coutries.ContainsKey("India"))
        {
            coutries.Remove("India");
            Console.WriteLine("ky removed");
        }
        foreach (var item in coutries)
        {
            Console.WriteLine(item.Value);
        }

        Console.ReadLine();

    }
}