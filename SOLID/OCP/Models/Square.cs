namespace OCP.Models
{
    internal class Square : Figure
    {
        public double Vertex { get; set; }

        public override double CalcArea()
        {
            return Math.Pow(Vertex, 2);
        }
    }
}
