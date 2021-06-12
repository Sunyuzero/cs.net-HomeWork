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
            
            using(var db = new OrderContext())
            {
                var ord = new Order {ID=id,Customer=customer,Time=DateTime.Now };
                ord.Details.Add(details);
                db.orders.Add(ord);
                db.SaveChanges();
            }

            Console.WriteLine("订单创建成功");
        }

        public void deleteOrder(String info)
        {
            using(var context = new OrderContext())
            {
                var ord = context.orders.Include("OrderDetails").FirstOrDefault
                    (o => o.Customer.Name == info || o.TotalValue.ToString() == info || o.ID.ToString() == info);
                if(ord!=null)
                {
                    context.orders.Remove(ord);
                    context.SaveChanges();
                }

            }
        }
        
        public void modifyOrder(String ID, String name, String commodities, int amount, String address, DateTime date)
        {
            if (searchOrder(ID) != null) throw new OrderException("修改订单失败，查不到此订单", 1);
            if (amount < 0) throw new OrderException("修改失败，金额不能小于0", 2);
            if (!Commodities.dic.ContainsKey(commodities)) throw new OrderException("修改失败,不存在该商品", 5);

            using (var context = new OrderContext())
            {
                var ord = context.orders.Include("OrderDetails").FirstOrDefault(o => o.ID.ToString() == ID);   
                ord.Customer.Name = name;
                ord.Customer.CommoditiesBought = commodities;
                OrderDetails detail = new OrderDetails(commodities, amount);
                ord.Details.Clear();
                ord.Details.Add(detail);
                ord.Time = date;
                Console.WriteLine("修改成功");
             }
         }
        

        public List<Order> searchOrder(String info)
        {
            using (var context = new OrderContext())
            {
                var ord = context.orders.Include("OrderDetails").Where
                    (o => o.Customer.Name == info || o.TotalValue.ToString() == info || o.ID.ToString() == info).OrderBy(o=>o.ID);
                if (ord==null)
                {
                    Console.WriteLine("无此订单");
                    return null;
                }
                int i = 1;
                List<Order> orderlist = new List<Order>();
                foreach (var o in ord)
                {
                    orderlist.Add(o);
                    Console.WriteLine($"订单{i++}");
                    Console.WriteLine(o.ToString() + "\n");
                }
                return orderlist;
            }
        }

        public void printTotalOrder()
        {
            Console.WriteLine("所有的订单如下：");
            int i = 1;
            using (var context = new OrderContext())
            {
                var orders = context.orders.Include("OrderDetails");
                foreach(var ord in orders)
                {
                    Console.WriteLine($"订单{i++}");
                    Console.WriteLine(ord.ToString() + "\n");
                }
            }
             
        }

        public void Export(String path)
        {
            using (var context = new OrderContext())
            {
                var orders = context.orders.Include("OrderDetails");
                XmlSerializer serializer = new XmlSerializer(orders.GetType());
                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    serializer.Serialize(fs, orders);
                }
            }
        }

        public void import(String path)
        {
            using (var context = new OrderContext())
            {
                var orders = context.orders.Include("OrderDetails");
                XmlSerializer serializer = new XmlSerializer(orders.GetType());
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    List<Order> temp = (List<Order>)serializer.Deserialize(fs);
                    temp.ForEach(ord =>
                    {
                        if (!orders.Contains(ord))
                        {
                            context.orders.Add(ord);
                        }
                    });
                }
            }
        }

    }


}
