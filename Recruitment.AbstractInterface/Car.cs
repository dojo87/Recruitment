using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.AbstractInterface
{
    public class Car
    {
        public Car(string name, int productionYear, double fuelConsumption)
        {
            this.Name = name;
            this.ProductionYear = productionYear;
            this.FuelConsumption = fuelConsumption;
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
            return oneLitreCost * (FuelConsumption / 100.0) * kilometersToDrive;
        }
    }
}
