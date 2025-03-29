namespace FindYourCarAPI.Data.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public required string Brand { get; set; }
        public required string Type { get; set; }
        public required string Name { get; set; }

    }
}
