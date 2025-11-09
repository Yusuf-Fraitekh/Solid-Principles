namespace SolidPrinciplesPractice.LSP.Vehicle.Before
{
    public class clsBicycle : clsVehicle
    {
        public override void StartEngine()
        { 
            Console.WriteLine("Bicycles don't have engines.");
        }

        public override void Drive()
        {
            Console.WriteLine("Bicycle is riding...");
        }
    }

}
