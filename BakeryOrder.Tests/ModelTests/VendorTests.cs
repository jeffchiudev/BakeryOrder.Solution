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
    }
}