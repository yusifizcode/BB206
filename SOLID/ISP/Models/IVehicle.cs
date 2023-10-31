namespace ISP.Models
{
    internal interface IVehicle
    {
        byte WheelCount { get; set; }

        void Drive();
    }
}
