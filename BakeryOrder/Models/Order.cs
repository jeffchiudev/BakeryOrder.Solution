namespace BakeryOrder.Models
{
    public class Order //This class should include properties for the title, the description, the price, the date, and any other properties you would like to include.
    {
        public string Title { get; set; } 
        public string Description { get; set; } 
        public int Price { get; set; } 
        public string Date { get; set; } 

        public Order(string title, string description, int price, string date)
        {
            Title = title;
            Description = description;
            Price = price;
            Date = date;
        }
    }
}