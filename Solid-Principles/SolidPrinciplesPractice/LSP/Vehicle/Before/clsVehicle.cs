using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesPractice.LSP.Vehicle.Before
{
    public class clsVehicle
    {
        public virtual void StartEngine()
        {
            Console.WriteLine("Starting engine...");
        }

        public virtual void Drive()
        {
            Console.WriteLine("Driving...");
        }
    }

}
