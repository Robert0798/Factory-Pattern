namespace FactoryPattern;

public class ConsoleLogger 
{
    public static void VehicleStartUpDialogue()
    {
        Console.WriteLine("Put Key in ignition");
        Thread.Sleep(1000);
        Console.WriteLine("Turn key");
    }
    
}