using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderProgram;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProgram
{

    [TestClass()]
    public class OrderServiceTests
    {
        OrderService Service = new OrderService();

        [TestInitialize]
        public void Init()
        {
            OrderDetails orderDetails1 = new OrderDetails("banana", 1);
            OrderDetails orderDetails2 = new OrderDetails("banana", 2);

            Customer customer1 = new Customer("C1", "banana", "A1");
            Customer customer2 = new Customer("C2", "banana", "A2");

            Order order1 = new Order(1, customer1, new DateTime(2021, 1, 1));
            order1.Details.Add(orderDetails1);

            Order order2 = new Order(2, customer2, new DateTime(2021, 1, 2));
            order2.Details.Add(orderDetails2);

            Service.orders.Add(order1);
            Service.orders.Add(order2);
        }

        [TestMethod()]
        public void createOrderTest()
        {
            OrderService service = new OrderService();
            service.createOrder(1,"C1", "banana", 1, "A1");
            Assert.IsTrue(service.orders.Count == 1);
            Assert.IsTrue(service.orders.Contains(Service.orders[0]));
        }

        [ExpectedException(typeof(OrderException))]
        public void createOrderTest1()
        {
            Service.createOrder(1, "C1", "banana", 1, "A1");
        }

        [TestMethod()]
        public void deleteOrderTest()
        {
            Order order = Service.orders[1];
            Service.deleteOrder("1");
            Assert.IsTrue(Service.orders.Count == 1);
            Assert.IsFalse(Service.orders.Contains(order));
        }

        [TestMethod()]
        public void modifyOrderTest()
        {
            Order order = Service.orders[0];

            OrderDetails details = new OrderDetails("apple", 5);
            Customer customer = new Customer("C3", "apple", "A3");
            Order testOrder = new Order(1, customer, new DateTime(2021, 1, 3));

            OrderService service = new OrderService();
            service.orders.Add(order);

            service.modifyOrder("1", "C3", "apple", 5, "A3", new DateTime(2021, 1, 3));
            Assert.IsTrue(service.orders[0] == order);
        }

        [TestMethod()]
        public void searchOrderTest()
        {
            OrderDetails orderDetails = new OrderDetails("banana", 1);
            Customer customer = new Customer("C1", "banana", "A1");
            Order order = new Order(1, customer,new DateTime(2021,1,1));

            List<Order> testOrders = Service.searchOrder("1");
            Assert.AreEqual(order, testOrders[0]);
        }

        [TestMethod()]
        public void exportTest()
        {
            String path = "Order.xml";
            Service.Export(path);
            Assert.AreEqual(File.ReadAllText(path), File.ReadAllText("TestXML.xml"));
            File.Delete(path);
        }

        [TestMethod()]
        public void importTest()
        {
            String path = "TestXML.xml";
            OrderService service = new OrderService();
            service.import(path);
            CollectionAssert.AreEqual(Service.orders, service.orders);
        }
    }
}