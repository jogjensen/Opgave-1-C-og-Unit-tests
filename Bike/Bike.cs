using System;

namespace Bike
{
    public class Bike
    {

        static void Main(string[] args)
        {
        }

        #region Instance fields

        private int _id;
        private string _color;
        private int _price;
        private int _gear;

        #endregion

        #region Properties

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Color
        {
            get { return _color; }
            set
            {
                if (value.Length < 1)
                    throw new ArgumentException();
                else _color = value;
            }
        }

        public int Price
        {
            get { return _price; }
            set
            {
                if (1 <= value) _price = value;
                else throw new ArgumentOutOfRangeException("Price", value, "Illegal price");
            }
        }

        public int Gear
        {
            get { return _gear; }
            set
            {
                if (3 <= value && value <= 23) _gear = value;
                else throw new ArgumentOutOfRangeException("Gear", value, "Gear out of range");
            }
        }

        #endregion

        #region Constructor

        public Bike(int id, string color, int price, int gear)
        {
            Id = id;
            Color = color;
            Price = price;
            Gear = gear;
        }


        #endregion

    }
}

