namespace ISP.Models
{
    internal class Car : IVehicle, IEnginable
    {
        public byte WheelCount { get; set; }
        public double HorsePower { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double FuelCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddFuel()
        {
            throw new NotImplementedException();
        }

        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void RemoveFuel()
        {
            throw new NotImplementedException();
        }
    }
}
