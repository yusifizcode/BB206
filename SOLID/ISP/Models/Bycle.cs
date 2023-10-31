namespace ISP.Models
{
    internal class Bycle : IVehicle, IFakeEnginable
    {
        public byte WheelCount { get; set; }

        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void MakeEngineSoundWithBottle()
        {
            throw new NotImplementedException();
        }
    }
}
