using System.Collections;

namespace Collections;
public class Program
{
    public static void Main(string[] args)
    {
        #region

        //Array list ...................................................................
        //Array list but prefer List over this as its provide more type saftey
       /* ArrayList aList = new ArrayList();
        //Array list can store various type of data types
        //capacity of an array get increasesd as we keep adding the items inside it
        //capacity is 0 initially
        //if you add one item inside the arraylist then its capacity increases to 4
        //and if items exceed 4 nos like 5 then it auto doubles the capcity like 8 and so on
        //so capacity gets doubled  
        Console.WriteLine($"count: {aList.Capacity}");
        aList.Add("BOB");
        aList.Add(123);
        aList.Add(true);
        aList.Add(false);
        aList.Add(619.1223);
        Console.WriteLine($"count: {aList.Count}");
        Console.WriteLine($"Capacity is: {aList.Capacity}");
        ArrayList aList2 = new ArrayList();
        aList2.AddRange(new object[] { "test1", true, 124, "check" });// add any type of  array of objects
        Console.WriteLine($"alist 2 count : {aList2.Count}");
        Console.WriteLine($"alis 2 Capacity is: {aList2.Capacity}");
        //we can add previous list to new existing lsit
        aList2.AddRange(aList);
        // we can use alist.sort  or alist.reverse if all the types are same

        aList.Insert(1,"thor");
        aList2.RemoveAt(0);
        aList2.RemoveRange(0, 2); // seconnd argument is for the count
        Console.WriteLine($"Thor index is {aList.IndexOf("thor",0)}");
        //in index of second argument is for search start index
        foreach (object item in aList2)
        {
            Console.WriteLine(item);
        }

        string[] arr = (string[])aList2.ToArray(typeof(string)); //converting array into string array

        string[] newArr = { "wow", "check", "cool" }; //converting string array into array list

        ArrayList newArrFromStringArr = new ArrayList();
        newArrFromStringArr.AddRange(newArrFromStringArr);*/


        //2) Dictionary....... this id done in part eight

        //3) Queues
        //first in first out

      /*  Queue q = new Queue();
        q.Enqueue(1); //adds object aththe end of the queue
        q.Enqueue(2);
        q.Enqueue(3);

        Console.WriteLine($"1 in Queue {q.Contains(1)}");
        Console.WriteLine($"Remove{q.Dequeue()}"); //removes and returns the objcect at front
        Console.WriteLine($"peek 1 {q.Peek()}"); //returns the object at the beginning without removing it.
        
        object[] numArr = q.ToArray();
        Console.WriteLine(String.Join(",", numArr));

        foreach (object item in numArr)
        {
            Console.WriteLine($"Queue {item}");
        }
        q.Clear(); //removes all objects from the queues*/
        

       //4) Stacks

        /*Stack stack = new Stack(); //last in first out

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        Console.WriteLine($"peek  {stack.Peek()}"); //will show last object without removing it
        Console.WriteLine($"Pop  {stack.Pop()}"); //will remove last object and will remove it
        Console.WriteLine($"contains {stack.Contains(1)}");
        object[] numArr = stack.ToArray();
        Console.WriteLine(String.Join(",", numArr));
        foreach (var item in numArr)
        {
            Console.WriteLine($"{item}");
        }
        stack.Clear();*/

        //5)) Generics

        #endregion
    }
}