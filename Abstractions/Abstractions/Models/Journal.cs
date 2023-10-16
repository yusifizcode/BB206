namespace Abstractions.Models
{
    public class Journal : Product
    {
        public string CompanyName { get; set; }
        public override string GetInfo()
        {
            return $"{Name} {Price} - Company: {CompanyName}";
        }
    }
}
