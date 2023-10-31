namespace OCP.Models
{
    internal class Rectangle : Figure
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public override double CalcArea()
        {
            return Height * Width;
        }
    }
}
