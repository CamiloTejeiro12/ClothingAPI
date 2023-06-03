namespace ClothingAPI.Models
{
    public class Clothing
    {
        public int Id { get; set; }
        public string? Type { get; set; }
        public string? Size { get; set; }
        public string? Description { get; set; }
        public int Price { get; set; }
    }

    public class ClothingUpdate
    {
        public string? Type { get; set; }
        public string? Size { get; set; }
        public string? Description { get; set; }
        public int Price { get; set; }
    }
}


//id, type, size, description, price