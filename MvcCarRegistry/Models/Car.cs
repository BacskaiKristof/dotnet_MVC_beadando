namespace MvcCarRegistry.Models
{
    public class Car
    {
        public int Id {  get; set; }
        public string? Brand { get; set; }

        public string? Type { get; set; }

        public int Year {  get; set; }

        public decimal Price { get; set; }

        public string? LicensePlate { get; set; }
    }
}
