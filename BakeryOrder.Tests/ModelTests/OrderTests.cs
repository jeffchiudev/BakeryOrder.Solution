using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryOrder.Models;

namespace BakeryOrder.Tests
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void OrderConstructor_CreatesOrderInstance_Order()
        {
            Order testOrder = new Order();
            Assert.AreEqual(typeof(Order), testOrder.GetType());
        }
    }   
}