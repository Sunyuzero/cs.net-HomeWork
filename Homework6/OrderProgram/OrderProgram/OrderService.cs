using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Diagnostics;
using System.Linq;
using System.IO;
using System.Xml.Serialization;

namespace OrderProgram
{
    public class OrderService
    {
        public List <Order> orders = new List<Order>();
        Commodity commodities = new Commodity();

        public void createOrder(String name,String commodity,int amount,String address)
        { 
            //创建客户信息
            Customer customer = new Customer();
            customer.Name = name;
            customer.Address = address;
            customer.commoditiesBought.Add(commodity);

            Order order = new Order();

            //创建订单明细
            OrderDetails details = new OrderDetails(commodity, amount);
            order.details.Add(details) ;

            //创建订单信息
            order.ID = "A" + new Random(BitConverter.ToInt32(Guid.NewGuid().ToByteArray(), 0)).Next(0,10000000).ToString();
            order.customer = customer;
            order.TotalValue += details.UnitTotalValue;
            order.Time = DateTime.Now.ToString();
            orders.Add(order);

            Console.WriteLine("订单创建成功:\n" + order.ToString() + "\n");

        }

        public void deleteOrder(String info)
        {
            if (!searchOrder(info)) throw new OrderException("删除订单失败，查找不到此订单", 0);

            for (int i = 0; i < orders.Count(); i++)
            {
                if (orders[i].customer.Name == info ||
                        orders[i].TotalValue.ToString() == info ||
                        orders[i].ID == info)
                {
                    orders.Remove(orders[i--]);
                }
            }

            Console.WriteLine("删除成功，现在所有的订单为：");
            printTotalOrder();

        }

        public void modifyOrder(String ID)
        {
            if (!searchOrder(ID)) throw new OrderException("修改订单失败，查不到此订单", 1);

            Console.WriteLine("请修改订单：");

            Console.Write("totalValue："); 
            double newValue = double.Parse(Console.ReadLine());
            if (newValue < 0) throw new OrderException("修改失败，金额不能小于0", 2);

            Console.Write("name："); 
            String newName = Console.ReadLine();

            Console.Write("buy："); 
            String commodity = Console.ReadLine();
            if (!commodities.dic.ContainsKey(commodity)) throw new OrderException("修改失败，没有此商品",4);

            foreach (Order order in orders)
            {
                if (order.ID == ID)
                {
                    order.TotalValue = newValue;
                    order.customer.Name = newName;
                    order.customer.commoditiesBought.Clear();
                    order.customer.commoditiesBought.Add(commodity);
                    order.Time = DateTime.Now.ToString();
                    Console.WriteLine("修改成功，订单为：\n" + order);
                }
            }
        }

        public bool searchOrder(String info)
        { 
            IEnumerable<Order> query = null;

            query = from s in orders
                    from q in s.customer.commoditiesBought
                    where q == info || s.customer.Name == info || s.TotalValue.ToString() == info || s.ID == info
                    orderby s.TotalValue ascending
                    select s;

            if(query.Count() == 0)
            {
                Console.WriteLine("无此订单");
                return false;
            }

            int i = 1;
            foreach (Order order in query)
            {
                Console.WriteLine($"订单{i++}");
                Console.WriteLine(order.ToString() + "\n");
            }

            return true;
        }

        public void printTotalOrder()
        {
            if(orders.Count  == 0)
            {
                Console.WriteLine("没有订单\n");
                return;
            }
            Console.WriteLine("所有的订单如下：");
            int i = 1;
            foreach(Order order in orders)
            {
                Console.WriteLine($"订单{i++}");
                Console.WriteLine(order.ToString() + "\n");
            }
        }

             
        public void export()
        {
            XmlSerializer serializer = new XmlSerializer(orders.GetType());
            using (FileStream fs = new FileStream("order.xml", FileMode.Create, FileAccess.Write))
            {
                serializer.Serialize(fs, orders);
            }

        }

        public void import()
        {
            XmlSerializer serializer = new XmlSerializer(orders.GetType());
            using (FileStream fs = new FileStream("order.xml", FileMode.Open, FileAccess.Read))
            {
                List<Order> lists = (List<Order>)serializer.Deserialize(fs);
                lists.ForEach( (ord) => orders.Add(ord) );
            }
        }

    }
}
