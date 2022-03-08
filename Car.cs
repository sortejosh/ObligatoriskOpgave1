using System;

namespace ObligatoriskOpgave1
{
    public class Car
    {
        private int _id;
        private string _model;
        private int _price;
        private string _licensePlate;

        public Car(int id, string model, int price, string licensePlate)
        {
            Id = id;
            Model = model;
            Price = price;
            LicensePlate = licensePlate;
        }
        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Model
        {
            get => _model;
            set => _model = value;
        }

        public int Price
        {
            get => _price;
            set => _price = value;
        }

        public string LicensePlate
        {
            get => _licensePlate;
            set => _licensePlate = value;
        }
    }
}
