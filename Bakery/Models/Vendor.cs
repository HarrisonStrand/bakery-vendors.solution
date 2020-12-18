using System.Collections.Generic;

namespace Bakery.Models
{
  public class Vendor
  {
    private static List<Vendor> _vendors = new List<Vendor> { };
    public string VendorName { get; set; }
    public string VendorDescription { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }
    public Vendor(string vendorName)
    {
      VendorName = vendorName;
      _vendors.Add(this);
      Id = _vendors.Count;
      Orders = new List<Order> { };
    }
    public Vendor(string vendorName, string vendorDescription)
      : this(vendorDescription)
    {
      VendorDescription = vendorDescription;
    }
    public static List<Vendor> GetAll()
    {
      return _vendors;
    }
    public static Vendor Find(int searchId)
    {
      return _vendors[searchId-2];
    }
    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
    public static void ClearAll()
    {
      _vendors.Clear();
    }
  }
}