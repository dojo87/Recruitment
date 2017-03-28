using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.AbstractInterface
{
    public class Maluch
    {
        public Maluch(int productionYear)
        {
            this.Name = "Maluch";
            this.ProductionYear = productionYear;
            this.FuelConsumption = 6.7;
        }

        public string Name
        {
            get;
            private set;
        }
        public int ProductionYear
        {
            get;
            private set;
        }
        public double FuelConsumption
        {
            get;
            private set;
        }

        public int CalculateAge()
        {
            return DateTime.Now.Year - ProductionYear;
        }

        public double CalculateTripCost(double kilometersToDrive, double oneLitreCost)
        {
            // Maluch will burn more and more as it ages.
            double realisticFuelConsuption = FuelConsumption * ((double)CalculateAge() / 10.0);

            return oneLitreCost * (realisticFuelConsuption / (double)100) * kilometersToDrive;
        }

        public void StartWithStick()
        {
            System.Console.WriteLine("Klankklankklank brruuuum");
        }
    }
}
