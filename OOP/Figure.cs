namespace OOP
{
    public abstract class Figure
    {
        protected bool isValid(params int[] numbers)
        {
            foreach(var x in numbers)
                if(x <= 0)
                    return false;
            return true;
        }

        public abstract double GetPerimeter();

        public abstract double GetSquare();
    }
}
