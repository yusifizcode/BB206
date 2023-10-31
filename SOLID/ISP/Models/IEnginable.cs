namespace ISP.Models
{
    internal interface IEnginable
    {
        double HorsePower { get; set; }
        double FuelCapacity { get; set; }

        void AddFuel();
        void RemoveFuel();
    }
}
