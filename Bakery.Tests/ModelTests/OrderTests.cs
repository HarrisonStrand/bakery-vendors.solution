using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetTitle_ReturnsOrderTitle_String()
    {
      string title = "order title!";
      Order newOrder = new Order(title);
      string result = newOrder.OrderTitle;
      Assert.AreEqual(title, result);
    }
        [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      string title = "this is a title";
      Order newOrder = new Order(title);
      string updatedTitle = "this is the new title";
      newOrder.OrderTitle = updatedTitle;
      string result = newOrder.OrderTitle;
      Assert.AreEqual(updatedTitle, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_ItemList()
    {
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    // [TestMethod]
    // public void GetAll_ReturnsItems_ItemList()
    // {
    //   string description01 = "Walk the dog";
    //   string description02 = "Wash the dishes";
    //   Item newItem1 = new Item(description01);
    //   Item newItem2 = new Item(description02);
    //   List<Item> newList = new List<Item> { newItem1, newItem2 };
    //   List<Item> result = Item.GetAll();
    //   CollectionAssert.AreEqual(newList, result);
    // }
  }
}