using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OrderProgram
{
    class Test
    {
        static void Main()
        {
            OrderService Service = new OrderService();
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

            //Service.Export("TestXML.xml");
            Console.ReadLine();
        }
    }
}
