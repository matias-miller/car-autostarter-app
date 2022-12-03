using System;
using System.Collections.Generic;
using System.Text;

namespace CarAutoStarter.Models
{
    public class Cars
    {
        private List<Car> ListOfCars = new List<Car>();

        public void AddCar(Car NewCar)
        {
            ListOfCars.Add(NewCar);
        }

    }
}
