namespace PartTen;

internal class PartTen
{
    public static void Main(string[] args)
    {

        //exception handling ..............................................

        /*Console.WriteLine("Enter a numnber: ");
        //try cathc do not break the flow of execution and it'll not blow up the app 
		try
		{
			int num =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( num );
		}
        catch (OverflowException e)
        {

            Console.WriteLine($"Somrthing is wrong here : {e.Message}");
        }
        catch (FormatException e)
        {

            Console.WriteLine($"Somrthing is wrong here : {e.Message}");
        }
        catch (Exception e)
		{

            Console.WriteLine($"Somrthing is wrong here : {e.Message}");
        }

        Console.WriteLine("it executed even after exception!");*/


        //DEBUGGING.............................................
/*
        int age = 35;
        if (age > 18)
        {
            Console.WriteLine("age is 18+");
        }
        else if (age > 30)
        {
            Console.WriteLine( "30+");
        }*/

        //Local/Auto Window..........................................................
        // if we don't see local  or auto   TAB
        //then select the window dropdown toolbar> select reset window layout
        //then you'll see Autos/Locals/watch 1 tab at down left corner of the
        //Autos: while debugging it'll show the active debugging line's variable and it'll showall
        //othr variables which there after being traced by debugging.
        //locals: it'll show all the variables in the "scope", and it'll asiign it's value time to time after debugging is traced


        //  Watch window...................................................................
        // here we can add variables into the watch table for debugginf to see what's the value of a variable.
        //we can add the variable in the watch table by righ clicking on variable>select add to watch
        Console.ReadLine();
    }
}
