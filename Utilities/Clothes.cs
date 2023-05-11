using ClothingAPI.Models;
namespace ClothingAPI.Utilities

{
    public class Clothes
    {
        public List<Clothing> clothes;
        public Clothes() {
            clothes = new List<Clothing>();
            clothes.Add(new Clothing()
            {
                Id = 1,
                Type = "T-Shirt",
                Size = "M",
                Description = "Black T-Shirt oversize",
                Price = 50000,
            });
            clothes.Add(new Clothing()
            {
                Id = 2,
                Type = "Dress",
                Size = "7",
                Description = "Pinky Dress children",
                Price = 150000,
            });
            clothes.Add(new Clothing()
            {
                Id = 3,
                Type = "Sweatshirt",
                Size = "L",
                Description = "Gray hooded sweatshirt",
                Price = 90000,
            });
            clothes.Add(new Clothing()
            {
                Id = 4,
                Type = "Dress",
                Size = "S",
                Description = "Red spaghetti strap dress",
                Price = 120000,
            });
            clothes.Add(new Clothing()
            {
                Id = 5,
                Type = "Jacket",
                Size = "M",
                Description = "Brown leather jacket",
                Price = 250000,
            });
        }
        public bool newClothe(Clothing clothing)
        {
            clothes.Add(clothing);

            return true;
        }
        public Clothing getClothe(int id) {

            return clothes.FirstOrDefault(clothe=> clothe.Id.Equals(id));
        }
        public bool updateClothe(int id, Clothing clothing)
        {
            Clothing storedClothe=getClothe(id);
            if (storedClothe == null)
            {
                Console.WriteLine("Not found id");
                return false;
            }

            storedClothe.Type = clothing.Type;
            storedClothe.Size = clothing.Size;
            storedClothe.Description = clothing.Description;
            storedClothe.Price = clothing.Price;

            clothes[clothes.IndexOf(storedClothe)] = storedClothe;

            return true;
        }

        public bool removeClothe(int id)
        {
            Clothing storedClothe = getClothe(id);
            if (storedClothe == null)
            {
                Console.WriteLine("Not found id");
                return false;
            }

            clothes.Remove(storedClothe);

            return true;
        }

        public List<Clothing> getAllClothing()
        {
            return clothes;
        }

    }
}




//id, type, size, description, price