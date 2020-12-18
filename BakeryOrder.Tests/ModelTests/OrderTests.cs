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
            Order testOrder = new Order("care", "10 baguette", 15, "Jan 1st");
            Assert.AreEqual(typeof(Order), testOrder.GetType());
        }

        [TestMethod]
        public void OrderDetails_ReturnsDetailsOfOrder_NewOrder()
        {
            string title = "Leaping Frog cafe";
            string description = "20 croissant";
            int price = 30;
            string date = "20th December";
            Order testOrder = new Order(title, description, price, date);
            Assert.AreEqual(title, testOrder.Title);
            Assert.AreEqual(description, testOrder.Description);
            Assert.AreEqual(price, testOrder.Price);
            Assert.AreEqual(date, testOrder.Date);   
        }

        [TestMethod]
        public void GetAll_ReturnsEmptyOrder_OrderList()
        {
            List<Order> testOrder = new List<Order> { };
            List<Order> testResult = Order.GetAll();
            CollectionAssert.AreEqual(testOrder, testResult);
        }
    }   
}