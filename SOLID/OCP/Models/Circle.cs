namespace OCP.Models
{
    internal class Circle : Figure
    {
        public double Radius { get; set; }

        public override double CalcArea()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }
    }
}
