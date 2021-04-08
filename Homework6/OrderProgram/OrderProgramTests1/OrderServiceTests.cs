using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderProgram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProgram.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        [TestMethod()]
        public void createOrderTest()
        {
            OrderService s1 = new OrderService();
            s1.createOrder("A", "B", 1, "D");

            Customer customer = new Customer();
            customer.Name = "A";
            customer.Address = "D";
            customer.commoditiesBought.Add("B");

            Order order = new Order();

            OrderDetails details = new OrderDetails("B", 1);
            order.details.Add(details);

            order.customer = customer;
            order.TotalValue += details.UnitTotalValue;
            order.Time = DateTime.Now.ToString();

            List<Order> list = new List<Order>();
            list.Add(order);

            CollectionAssert.Equals(list, s1.orders);
            Assert.AreEqual(1, s1.orders.Count);
        }

        [TestMethod()]
        public void deleteOrderTest()
        {
            OrderService s = new OrderService();
            s.createOrder("A", "B", 1, "D");
            s.createOrder("B", "C", 2, "D");

            s.deleteOrder("A");
            Assert.AreEqual(1, s.orders.Count);
        }
    }
}