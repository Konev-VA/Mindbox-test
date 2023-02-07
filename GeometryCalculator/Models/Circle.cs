namespace GeometryCalculator.Models
{
    public class Circle
    {

        #region Properties

        private double _radius;
        public double Radius
        {
            get { return _radius; }
            //Возможность изменения радиуса находится под вопросом,
            //но в силу отсутсвия контекста, она была реализована
            set
            {
                _area = GetArea(value);
                //Была убрана отдельная проверка радиуса, т.к. она осуществлена при установке площади,
                //следовательно, при неверном радиусе выполнение программы
                //прервётся на предыдущем шаге
                _radius = value;
            }

        }

        private double _area;
        public double Area { get => _area; }

        #endregion

        public Circle(double radius) => Radius = radius;

        public static double GetArea(double radius)
        {
            if (!RadiusIsValid(radius))
                throw new Exception("A circle with such a radius cannot exist.");

            return Math.Round((Math.PI * Math.Pow(radius, 2)), 2);
        }

        private static bool RadiusIsValid(double radius)
        {
            return !(radius <= 0);
        }
    }
}
