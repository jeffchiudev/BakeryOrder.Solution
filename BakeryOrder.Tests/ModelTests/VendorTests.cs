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
    }
}