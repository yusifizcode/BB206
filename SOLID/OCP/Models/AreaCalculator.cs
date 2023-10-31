namespace OCP.Models
{
    internal class AreaCalculator
    {
        //public double area = 0;

        public double CalcArea(Figure figure)
        {
            return figure.CalcArea();
        }

        //public double CalcArea(object figure)
        //{
        //    if (figure is Circle)
        //    {
        //        Circle circle = (Circle)figure;
        //        area = Math.Pow(circle.Radius, 2) * Math.PI;
        //    }
        //    else if (figure is Square)
        //    {
        //        Square square = (Square)figure;
        //        area = Math.Pow(square.Vertex, 2);
        //    }

        //    return area;
        //}
    }
}
