namespace FactoryPattern;

public class ThreeWheeler: IVehicle
{
    public ThreeWheeler()
    {
        
    }

    public void Drive()
    {
        ConsoleLogger.VehicleStartUpDialogue();
        Console.WriteLine("I have three wheels!?");
    }
        
    
}