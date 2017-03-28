using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.AbstractInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            // #1. Refactor Car, Polonez, Maluch classes so that they share: Name, PremiereYear, FuelConsumption properties.
            //     Make the CalculateYearsFromPremiere and CalculateTripCost methods inherited from the base class.

            // #2.
        }
    }

    public class CarTest
    {
        public void TestInheritedImplementation()
        {
            Car car1 = new Polonez();
            Car car2 = new Maluch();

            var cost1 = car1.CalculateTripCost(1200, 4.57m);
            var cost2 = car2.CalculateTripCost(1200, 4.57m);

            // What is missing to make this work:?
            System.Console.WriteLine("Costs for Polones are: {cost1}");
            System.Console.WriteLine("Costs for Maluch are: {cost2}");
        }
    }
    
}
