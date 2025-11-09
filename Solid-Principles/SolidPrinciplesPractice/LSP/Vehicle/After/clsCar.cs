namespace SolidPrinciplesPractice.Vehicle.After
{
    public class clsCar: clsMotorVehicle
    {
        public override void Drive()
        {
            Console.WriteLine($"Driving a car.");
        }
        public override void StartEngine()
        {
            Console.WriteLine($"Starting the engine of the car....");
        }
    }
}
