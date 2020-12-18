using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsVendorName_String()
    {
      string name = "Vendor name!";
      Vendor newVendor = new Vendor(name);
      string result = newVendor.VendorName;
      Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void SetName_SetName_String()
    {
      string name = "this is a name";
      Vendor newVendor = new Vendor(name);
      string updatedName = "this is the new name";
      newVendor.VendorName = updatedName;
      string result = newVendor.VendorName;
      Assert.AreEqual(updatedName, result);
    }
    [TestMethod]
    public void GetId_VendorInstantiateWithAnIdAndGetterReturns_Int()
    {
      string name = "Vendor name";
      Vendor newVendor = new Vendor(name);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_VendorList()
    {
      List<Vendor> newList = new List<Vendor> { };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    // [TestMethod]
    // public void GetAll_ReturnsVendors_VendorList()
    // {
    //   string title01 = "title One";
    //   string title02 = "title Two";
    //   Vendor newVendor1 = new Vendor(title01);
    //   Vendor newVendor2 = new Vendor(title02);
    //   List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
    //   List<Vendor> result = Vendor.GetAll();
    //   CollectionAssert.AreEqual(newList, result);
    // }
    // [TestMethod]
    // public void Find_ReturnsCorrectVendor_Vendor()
    // {
    //   string title01 = "This is a title";
    //   string title02 = "This is also a title";
    //   Vendor newVendor1 = new Vendor(title01);
    //   Vendor newVendor2 = new Vendor(title02);
    //   Vendor result = Vendor.Find(2);
    //   Assert.AreEqual(newVendor2, result);
    // }
  }
}