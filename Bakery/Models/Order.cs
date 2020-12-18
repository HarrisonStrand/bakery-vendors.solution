using System.Collections.Generic;

namespace Bakery.Models
{
  public class Order
  {
    public string OrderTitle { get; set; }
    public string OrderDescription { get; set; }
    public string OrderPrice { get; set; }
    public string OrderDate { get; set; }
    public int Id { get; }
    private static List<Order> _orders = new List<Order> { };
    public Order(string orderTitle, string orderDescription, string orderPrice, string orderDate)
    {
      OrderTitle = orderTitle;
      OrderDescription = orderDescription;
      OrderPrice = orderPrice;
      OrderDate = orderDate;
      _orders.Add(this);
      Id = _orders.Count;
    }
    public static List<Order> GetAll()
    {
      return _orders;
    }
    public static Order Find(int searchId)
    {
      return _orders[searchId-1];
    }
    public static void ClearAll()
    {
      _orders.Clear();
    }
  }
}