using System;

namespace OOP
{
    public class Rectangle : Square
    {
        protected readonly int _width;

        public Rectangle(int lenght, int width) 
            : base(lenght)
        {
            if (!isValid(width))
                throw new ArgumentException("The side must be greater than 0");
            _width = width;
        }

        public override double GetPerimeter() =>
            _width * 2 + _side * 2; 
        

        public override double GetSquare() =>
            _width * _side;
    }
}
