using System.Runtime.CompilerServices;

namespace PartEleven;

internal class PartEleven
{
    /* struct Person(string name, int age)
     {
         public string name = name;
         public int age = age;
     }*/

    protected TestInheritance animalIdInfo = new TestInheritance();
    public void SetAnimalInfo(int id, string ownerName)
    {
        animalIdInfo.IdNum = id;
        animalIdInfo.Owner = ownerName;
    }

    public void GetAnimalInfo()
    {
        Console.WriteLine($"id is {animalIdInfo.IdNum} and owner is {animalIdInfo.Owner}");
    }
    class Person
    {


        public string Name { get; set; }
        public int Age { get; set; }
        public int ReadOnly { get; } //this property is read only as it can not be set manually it should be set at constructor level

        // Read-only field
        public readonly string ReadOnlyField; // this is field not prop and "readonly" keyword can be used only on fields
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            //ReadOnly = readOnly;
            //ReadOnlyField = readOnlyField;

            Random rndf = new Random();
            ReadOnly = rndf.Next(1, 10000000);
            ReadOnlyField = rndf.Next(5000, 99999).ToString();
            // read only field or props can be set only at constructor level

        }


    }
    public static void Main(string[] args)
    {
        //structures
        string name = "aba";
        int age = 23;
        Person person = ReturnPerson();
        Console.WriteLine("test");
        Console.WriteLine($"{person.Name} and {person.Age} and the read only integer {person.ReadOnly} and field is  {person.ReadOnlyField}");
        PartEleven partEleven = new PartEleven();
        partEleven.SetAnimalInfo(person.ReadOnly, person.Name);
        partEleven.GetAnimalInfo();
    }

    static Person ReturnPerson()
    {
        /* Person person;
         person.age = 29;
         person.name = "anshul";
         return person;*/
        //alternate of this can be now

        return new Person("anshul", 29);
    }
    ///classess
    // in calsses while creatring its constructor we are not mandatory initialise the constructor with variable
    //in structures we are mandatory to realise that.
}