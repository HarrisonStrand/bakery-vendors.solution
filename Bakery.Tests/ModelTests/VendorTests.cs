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
    // [TestMethod]
    // public void GetTitle_ReturnsVendorTitle_String()
    // {
    //   string title = "Vendor title!";
    //   Vendor newVendor = new Vendor(title);
    //   string result = newVendor.VendorTitle;
    //   Assert.AreEqual(title, result);
    // }
    // [TestMethod]
    // public void SetTitle_SetTitle_String()
    // {
    //   string title = "this is a title";
    //   Vendor newVendor = new Vendor(title);
    //   string updatedTitle = "this is the new title";
    //   newVendor.VendorTitle = updatedTitle;
    //   string result = newVendor.VendorTitle;
    //   Assert.AreEqual(updatedTitle, result);
    // }
    // [TestMethod]
    // public void GetId_VendorInstantiateWithAnIdAndGetterReturns_Int()
    // {
    //   string title = "Vendor Title";
    //   Vendor newVendor = new Vendor(title);
    //   int result = newVendor.Id;
    //   Assert.AreEqual(1, result);
    // }
    // [TestMethod]
    // public void GetAll_ReturnsEmptyList_ItemList()
    // {
    //   List<Vendor> newList = new List<Vendor> { };
    //   List<Vendor> result = Vendor.GetAll();
    //   CollectionAssert.AreEqual(newList, result);
    // }
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