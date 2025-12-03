
namespace task1
{

    public class Rectangle
    {
        private double length;
        private double breadth;

        public double Length
        {
            get => length;
            set => length = value;
        }

        public double Breadth

        {
            get => breadth;
            set => breadth = value;
        }

        public double GetArea() => length* Breadth;
        public double Perimeter() => 2 * (Length + Breadth);

        public string showDetails() => $"length: {length}, breadth: {breadth}";

    }

}
