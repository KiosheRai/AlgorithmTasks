using System;

namespace OOP
{
    public class Square : Figure
    {
        protected readonly int _side;

        public Square(int side)
        {
            if (!isValid(side))
                throw new ArgumentException("The side must be greater than 0");
            _side = side;
        }

        public override double GetPerimeter() => 
            _side * 4;
        
        public override double GetSquare() =>
            _side * _side;
    }
}
