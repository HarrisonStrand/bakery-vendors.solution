using System.Collections.Generic;

namespace Bakery.Models
{
  public class Order
  {
    public string OrderTitle { get; set; }
    public string OrderDescription { get; set; }
    public int OrderPrice { get; set; }
    public int OrderDate { get; set; }
    public int Id { get; }
    private static List<Order> _orders = new List<Order> { };
    public Order(string orderTitle)
    {
      OrderTitle = orderTitle;
      _orders.Add(this);
      Id = _orders.Count;
    }
    public Order(string orderTitle, string orderDescription)
      : this(orderTitle)
    {
      OrderDescription = orderDescription;
    }
    public Order(string orderTitle, string orderDescription, int orderPrice)
      : this(orderTitle, orderDescription)
    {
      OrderPrice = orderPrice;
    }
    public Order(string orderTitle, string orderDescription, int orderPrice, int orderDate)
      : this(orderTitle, orderDescription, orderPrice)
    {
      OrderDate = orderDate;
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