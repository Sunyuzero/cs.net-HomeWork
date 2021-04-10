using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace OrderProgram
{
    public class OrderService
    {
        public List<Order> orders = new List<Order>();
        Commodity Commodities = new Commodity();

        public void createOrder(int id, String name, String commodity, int amount, String address)
        {

            //创建客户信息
            Customer customer = new Customer(name, commodity, address);

            //创建订单明细
            OrderDetails details = new OrderDetails(commodity, amount);

            //创建订单信息
            Order order = new Order(id, customer, DateTime.Now);
            order.addDetails(details);

            if (searchOrder(id.ToString()) != null) throw new OrderException("订单已经存在", 6);

            orders.Add(order);

            Console.WriteLine("订单创建成功");
        }

        public void deleteOrder(String info)
        {
            if (searchOrder(info) != null) throw new OrderException("删除订单失败，查找不到此订单", 0);

            for (int i = 0; i < orders.Count(); i++)
            {
                if (orders[i].Customer.Name == info ||
                        orders[i].TotalValue.ToString() == info ||
                        orders[i].ID.ToString() == info)
                {
                    orders.Remove(orders[i--]);
                }
            }

            Console.WriteLine("删除成功");
        }

        public void modifyOrder(String ID, String name, String commodities, int amount, String address, DateTime date)
        {
            if (searchOrder(ID) != null) throw new OrderException("修改订单失败，查不到此订单", 1);
            if (amount < 0) throw new OrderException("修改失败，金额不能小于0", 2);
            if (!Commodities.dic.ContainsKey(commodities)) throw new OrderException("修改失败,不存在该商品", 5);

            foreach (Order order in orders)
            {
                if (order.ID.ToString() == ID)
                {
                    order.Customer.Name = name;
                    order.Customer.CommoditiesBought = commodities;
                    OrderDetails detail = new OrderDetails(commodities, amount);
                    order.Details.Clear();
                    order.Details.Add(detail);
                    order.Time = date;
                    Console.WriteLine("修改成功");
                }
            }
        }

        public List<Order> searchOrder(String info)
        {
            IEnumerable<Order> query = null;

            query = from s in orders
                    where s.Customer.Address == info || s.Customer.Name == info ||
                            s.TotalValue.ToString() == info || s.ID.ToString() == info ||
                                s.Customer.CommoditiesBought == info
                    orderby s.TotalValue ascending
                    select s;

            if (query.Count() == 0)
            {
                Console.WriteLine("无此订单");
                return null;
            }

            int i = 1;
            List<Order> orderlist = new List<Order>();
            foreach (Order order in query)
            {
                orderlist.Add(order);
                Console.WriteLine($"订单{i++}");
                Console.WriteLine(order.ToString() + "\n");
            }
            return orderlist;
        }

        public void printTotalOrder()
        {
            Console.WriteLine("所有的订单如下：");
            int i = 1;
            foreach (Order order in orders)
            {
                Console.WriteLine($"订单{i++}");
                Console.WriteLine(order.ToString() + "\n");
            }
        }

        public void Export(String path)
        {
            XmlSerializer serializer = new XmlSerializer(orders.GetType());
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                serializer.Serialize(fs, orders);
                
            }
            
        }
        public void import(String path)
        {
            XmlSerializer serializer = new XmlSerializer(orders.GetType());
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                List<Order> temp = (List<Order>)serializer.Deserialize(fs);
                temp.ForEach(ord =>
                {
                    if (!orders.Contains(ord)) orders.Add(ord);
                });
            }
        }

    }


}
