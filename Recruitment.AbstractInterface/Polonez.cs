using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.AbstractInterface
{
    public class Polonez
    {
        public Polonez(int productionYear)
        {
            this.Name = "Polonez";
            this.ProductionYear = productionYear;
            this.FuelConsumption = 12.2;
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
            // Polonez will burn more and more as it ages.
            double realisticFuelConsuption = FuelConsumption * ((double)CalculateAge() / 10.0);

            return oneLitreCost * (realisticFuelConsuption / (double)100) * kilometersToDrive;
        }
    }
}
