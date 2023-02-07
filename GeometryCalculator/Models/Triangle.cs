namespace GeometryCalculator.Models
{
    public class Triangle
    {
        #region Properties
        public double A { get; init; }

        public double B { get; init; }

        public double C { get; init; }

        public double Area { get; init; }

        public TriangleType Type { get; init; }

        #endregion

        public Triangle(double a, double b, double c)
        {
            if (!CanExist(a, b, c))
                throw new Exception("A triangle with such sides does not exist");

            A = a;
            B = b;
            C = c;

            Type = GetTriangleType(a, b, c);

            Area = Math.Round(GetArea(), 2);
        }

        #region GetAreaMethods

        private double GetArea()
        {
            switch (Type)
            {
                case TriangleType.Right:
                    return GetRightTriangleArea();
                //Здесь также можно добавить проверку на остальные типы треугольников, если расширено определение в методе GetTriangleType()
                default:
                    return GetUndefinedTriangleArea();
            }
        }

        private double GetRightTriangleArea()
        {
            //Площадь прямоугольного треугольника рассчитывается, как половина произведения катетов
            List<double> sides = new List<double> { A, B, C };

            sides.Remove(sides.Max());

            return (sides[0] * sides[1]) / 2;

        }

        private double GetUndefinedTriangleArea()
        {
            //Площадь любого треугольника рассчитывается по формуле Герона
            double p = (A + B + C) / 2; //Не лучший нейминг, однако p является общепринятым обозначением для полупериметра

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        #endregion

        private TriangleType GetTriangleType(double a, double b, double c)
        {
            if (IsRigthTriangle(a, b, c))
                return TriangleType.Right;

            //Здесь могут быть добавлены проверки на остальные типы треугольников
            return TriangleType.Undefined;
        }

        private bool IsRigthTriangle(double a, double b, double c)
        {
            //Проверка трегольника на наличие прямого угла осуществляется при помощи Теоремы Пифагора
            var trianglesides = new List<double> { a, b, c };
            double largestSide = trianglesides.Max();

            double sumOfSquaredLegs = 0;

            trianglesides.Remove(largestSide);
            trianglesides.ForEach(x => sumOfSquaredLegs += Math.Pow(x, 2));

            if (Math.Pow(largestSide, 2) == sumOfSquaredLegs)
                return true;

            return false;

        }

        private bool CanExist(double a, double b, double c)
        {
            //Трегольники существуют только тогда, когда каждая сторона меньше суммы двух других
            if (a >= b + c)
                return false;
            if (b >= c + a)
                return false;
            if (c >= a + b)
                return false;

            return true;
        }
    }
    public enum TriangleType
    {
        Scalene,
        Isocelles,
        Equilateral,
        Acute,
        Right,
        Obtuse,
        Undefined
    }
}
