using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryOrder.Models;

namespace BakeryOrder.Tests
{
    [TestClass]
    public class BakeryTests
    {
        [TestMethod]
        public void VendorConstructor_CreatesVendor_Vendor()
        {
            Vendor testVendor = new Vendor("test");
            Assert.AreEqual(typeof(Vendor), testVendor.GetType());
        }
    }
}