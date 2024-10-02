namespace PartThirteen;

public class Program
{
    public static void Main(string[] args)
    {
        // Interfaces
        /*Vehicle vehicle = new Vehicle("BMW", 4, 160);

        if (vehicle is IVehicle)
        {
            vehicle.Move();
            vehicle.Stop();
        }
        else
        {
            Console.WriteLine( $"the {vehicle.BrandName} can not be driven.");
        }*/

        IElectronicDevice TV = TVRemote.GetDevice();
        PowerButton PW = new PowerButton(TV);
        PW.Execute();
        PW.Undo();

    }
}