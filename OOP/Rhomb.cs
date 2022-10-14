using System;

namespace OOP
{
    public class Rhomb : Square
    {
        protected readonly double _angle;

        public Rhomb(int side, double angle) 
            : base(side) 
        {
            _angle = Math.PI * angle / 180.0;
        }

        public override double GetSquare() => 
            Math.Pow(_side, 2) * Math.Sin(_angle);
    }
}
