using ClothingAPI.Models;
using System.Collections.Generic;

namespace ClothingAPI.Utilities
{
    public class Clothes
    {
        private List<Clothing> _clothes = new List<Clothing>()
            {
                new Clothing()
                {
                    Id = 1,
                    Type = "T-Shirt",
                    Size = "M",
                    Description = "Black T-Shirt oversize",
                    Price = 50000,
                },
                new Clothing()
                {
                    Id = 2,
                    Type = "Dress",
                    Size = "7",
                    Description = "Pinky Dress children",
                    Price = 150000,
                },
                new Clothing()
                {
                    Id = 3,
                    Type = "Sweatshirt",
                    Size = "L",
                    Description = "Gray hooded sweatshirt",
                    Price = 90000,
                },
                new Clothing()
                {
                    Id = 4,
                    Type = "Dress",
                    Size = "S",
                    Description = "Red spaghetti strap dress",
                    Price = 120000,
                },
                new Clothing()
                {
                    Id = 5,
                    Type = "Jacket",
                    Size = "M",
                    Description = "Brown leather jacket",
                    Price = 250000,
                }
            };

        public Clothes()
        {

        }

        public List<Clothing> ClothesList
        {
            get { return _clothes; }
            set { _clothes = value; }
        }

        public bool AddClothing(Clothing clothing)
        {
            _clothes.Add(clothing);
            return true;
        }

        public Clothing GetClothing(int id)
        {
            return _clothes.Find(clothing => clothing.Id == id);
        }

        public bool UpdateClothing(int id, Clothing clothing)
        {
            var storedClothing = GetClothing(id);
            if (storedClothing == null)
            {
                Console.WriteLine("Not found id");
                return false;
            }

            storedClothing.Type = clothing.Type;
            storedClothing.Size = clothing.Size;
            storedClothing.Description = clothing.Description;
            storedClothing.Price = clothing.Price;

            _clothes[_clothes.IndexOf(storedClothing)] = storedClothing;

            return true;
        }

        public bool RemoveClothing(int id)
        {
            var storedClothing = GetClothing(id);
            if (storedClothing == null)
            {
                Console.WriteLine("Not found id");
                return false;
            }

            _clothes.Remove(storedClothing);

            return true;
        }

        public List<Clothing> GetAllClothing()
        {
            return _clothes;
        }
    }
}
