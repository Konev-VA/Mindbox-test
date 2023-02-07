namespace GeometryCalculator.Models
{
    public class Circle
    {
        private double _radius;
        public double Radius
        {
            get { return _radius; }
            set
            {
                _radius = ValidateNewRadius(value);
                _area = GetArea(value);
            }

        }

        private double _area;
        public double Area { get => _area; }

        public Circle(double radius) => Radius = radius;

        //Допущено дублирование кода, но это позволяет пользователю без нужды не создавать обьект Circle, а просто обращаться к статичному методу, передавая радиус
        public static double GetArea(double radius)
        {
            if (!RadiusIsValid(radius))
                throw new Exception("A circle with such a radius cannot exist.");

            return Math.Round((Math.PI * Math.Pow(radius, 2)), 2);
        }

        private double ValidateNewRadius(double newRadius)
        {
            if (!RadiusIsValid(newRadius))
                throw new Exception("A circle with such a radius cannot exist.");

            return newRadius;
        }

        private static bool RadiusIsValid(double radius)
        {
            return !(radius <= 0);
        }
    }
}
