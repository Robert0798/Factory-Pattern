namespace FactoryPattern
{
    public class Car : IVehicle
    {
        public Car()
        {
            
        }

        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("Car is driving!");
        }
    }
}
