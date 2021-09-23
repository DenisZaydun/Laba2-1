using System;

namespace Лб2__1
{
    class Address
    {
        private int _index, _house, _apartment;
        private string _country, _city, _street;

        public int index
        {
            get
            {
                return _index;
            }
            set
            {
                _index = value;
            }
        }

        public string country
        {
            get
            {
                return _country;
            }
            set
            {
                _country = value;
            }
        }

        public string city
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }

        public string street
        {
            get
            {
                return _street;
            }
            set
            {
                _street = value;
            }
        }

        public int house
        {
            get
            {
                return _house;
            }
            set
            {
                _house = value;
            }
        }

        public int apartment
        {
            get
            {
                return _apartment;
            }
            set
            {
                _apartment = value;
            }
        }

        public void GetInfo()
        {
            Console.WriteLine($"Індекс: {_index}");
            Console.WriteLine($"Країна: {_country}");
            Console.WriteLine($"Місто: {_city}");
            Console.WriteLine($"Вулиця: {_street}");
            Console.WriteLine($"Будинок: {_house}");
            Console.WriteLine($"Квартира: {_apartment}");
        }
    }
}
