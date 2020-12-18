using System.Collections.Generic;

namespace BakeryOrder.Models
{
    public class Vendor //properties for the vendor's name, a description of the vendor, a List of Orders belonging to the vendor, and any other properties you would like to include.
    {
        private static List<Vendor> _instances = new List<Vendor> {};
        public string VendorName { get; set; }
        public int Id { get; }
        public List<Order> Orders { get; set; }

        public Vendor(string vendorName)
        {
            VendorName = vendorName;
            _instances.Add(this);
            Id = _instances.Count;
            Orders = new List<Order>{};
        }
    }
}