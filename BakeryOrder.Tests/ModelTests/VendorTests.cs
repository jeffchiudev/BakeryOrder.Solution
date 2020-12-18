using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryOrder.Models;

namespace BakeryOrder.Tests
{
    [TestClass]
    public class BakeryTests : IDisposable
    {

        public void Dispose()
        {
            Vendor.ClearAll();
        }

        [TestMethod]
        public void VendorConstructor_CreatesVendor_Vendor()
        {
            Vendor testVendor = new Vendor("test");
            Assert.AreEqual(typeof(Vendor), testVendor.GetType());
        }

        [TestMethod]
        public void GetId_ReturnsVendorId_Int()
        {
            string vendorName = "Heart Coffee";
            Vendor testVendor = new Vendor(vendorName);
            int result = testVendor.Id;
            Assert.AreEqual(1, result);
            
        }

        [TestMethod]
        public void GetAll_ReturnsVendorObjects_VendorList()
        {
            string vendorName = "Heart Coffee";
            Vendor testVendor = new Vendor(vendorName);
            List<Vendor> venList = new List<Vendor>{testVendor};
            List<Vendor> result = Vendor.GetAll();
            CollectionAssert.AreEqual(venList, result);
        }

        [TestMethod]
        public void Find_ReturnsVendor_Vendor()
        {
            string vendorName = "Heart Coffee";
            Vendor testVendor = new Vendor(vendorName);
            Vendor result = Vendor.Find(1);
            Assert.AreEqual(testVendor, result);
        }

        [TestMethod]
        public void AddOrder_AddsOrdersToVendor_OrderList()
        {
            string title = "Heart Coffee 10 croissant";
            string description = "10 croissant";
            int price = 30;
            string date = "20th December";
            Order testOrder = new Order(title, description, price, date);
            List<Order> newOrderList = new List<Order> { testOrder };
            string vendorName = "Heart Coffee";
            Vendor testVendor = new Vendor(vendorName);
            testVendor.AddOrder(testOrder);
            List<Order> result = testVendor.Orders;
            CollectionAssert.AreEqual(newOrderList, result);
        }
    }
}