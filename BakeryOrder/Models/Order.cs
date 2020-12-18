using System.Collections.Generic;

namespace BakeryOrder.Models
{
    public class Order //This class should include properties for the title, the description, the price, the date, and any other properties you would like to include.
    {
        public string Title { get; set; } 
        public string Description { get; set; } 
        public int Price { get; set; } 
        public string Date { get; set; } 
        public int Id { get; }
        private static List<Order> _instances = new List<Order> {};

        public Order(string title, string description, int price, string date)
        {
            Title = title;
            Description = description;
            Price = price;
            Date = date;
            _instances.Add(this);
            Id = _instances.Count;
        }

        public static List<Order> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }
        
        public static Order Find(int searchId)
        {
            return _instances[searchId - 1];
        }
    }
}