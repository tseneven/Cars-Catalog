using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Car:Car_Inreface
    {
        private string _name, _model, _mileage, _state, _vin, _owner;
        private int _lIn100Km;


        public Car(string name, string model, string mileage, string state, string vin, string owner, int lIn100Km)
        {
            Name = name;
            Model = model;
            Mileage = mileage;
            State = state;
            Vin = vin;
            Owner = owner;
            LIn100Km = lIn100Km;
        }

        public string Name { get => _name; set => _name = value; }
        public string Model { get => _model; set => _model = value; }
        public string Mileage { get => _mileage; set => _mileage = value; }
        public string State { get => _state; set => _state = value; }
        public string Vin { get => _vin; set => _vin = value; }
        public string Owner { get => _owner; set => _owner = value; }
        public int LIn100Km { get => _lIn100Km; set => _lIn100Km = value; }

        public void addObject(List<Car> cars, Car car)
        {
            var isTrue = cars.Contains(car);

            if (!isTrue)
            {
                cars.Add(car);
            }
        }

        public void removeObject(List<Car> cars, Car car)
        {
            var isTrue = cars.Contains(car);

            if (isTrue) 
            {
                cars.Remove(car);
            }
        }

    }
}
