using System;

namespace OOP
{
    public class Circle : Figure
    {
        protected int _radius;

        public Circle(int radius)
        {
            if (!isValid(radius))
                throw new ArgumentException("The radius must be greater than 0");
            _radius = radius;
        }

        public override double GetSquare() =>
            Math.PI * Math.Pow(_radius, 2);

        public override double GetPerimeter() =>
            2 * Math.PI * _radius; 
    }
}
