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
    public void GetId_OrderInstantiateWithAnIdAndGetterReturns_Int()
    {
      string title = "Order Title";
      Order newOrder = new Order(title);
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string title01 = "title One";
      string title02 = "title Two";
      Order newOrder1 = new Order(title01);
      Order newOrder2 = new Order(title02);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string title01 = "This is a title";
      string title02 = "This is also a title";
      Order newOrder1 = new Order(title01);
      Order newOrder2 = new Order(title02);
      Order result = Order.Find(2);
      Assert.AreEqual(newOrder2, result);
    }
  }
}