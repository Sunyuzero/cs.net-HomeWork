using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Diagnostics;
using System.Linq;

namespace Order.Models
{
    public class Commodity
    {
        public int ID { get; set; }
        public Dictionary<string, int> dic = new Dictionary<string, int>();

        public Commodity()
        {
            dic.Add("apple", 5);
            dic.Add("banana", 2);
        }
        public override string ToString()
        {
            String str = "";
            foreach (String Key in dic.Keys)
            {
                str += "[ " + Key + "：" + dic[Key] + " ]\n";
            }
            return str;
        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public String Name { get; set; }

        public List<String> commoditiesBought = new List<string>();

        public String Address { get; set; }
        public override string ToString()
        {
            String str = "";
            foreach (String commodity in commoditiesBought)
            {
                str = str + commodity + " ";
            }
            return "[ name：" + Name + " ， " + "buy：" + str + "]";
        }
    }

    public class OrderItem : IComparable
    {
        public String ID { get; set; }
        public Customer customer { get; set; }
        public String Time { get; set; }
        public double TotalValue { get; set; }

        public List<OrderDetails> details { get; set; }

        public override string ToString()
        {
            return "  ID：" + ID + " \n " + " TotalValue：" + TotalValue + "  \n " +
                          " Time：" + Time + " \n " + " customer：" + customer;
        }


        public override bool Equals(object obj)
        {
            if (!(obj is OrderItem)) throw new ArgumentException();
            OrderItem ord = (OrderItem)obj;
            return this.ID == ord.ID;
        }
        public int CompareTo(object obj)
        {
            if (!(obj is OrderItem)) throw new System.ArgumentException();
            OrderItem ord = (OrderItem)obj;
            return this.ID.CompareTo(ord.ID);
        }
    }


    public class OrderDetails
    {
        public int ID { get; set; }
        public Commodity commodity = new Commodity();

        public String UnitCommodity { get; set; }
        public int Amount { get; set; }
        public double UnitTotalValue { get; set; }

        public OrderDetails(String unitCommodity, int amount)
        {
            UnitCommodity = unitCommodity;
            Amount = amount;
            UnitTotalValue = amount * commodity.dic[unitCommodity];
        }

        public override string ToString()
        {
            return commodity.ToString() + "total：" + Amount;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is OrderDetails)) throw new ArgumentException();
            OrderDetails ord = (OrderDetails)obj;
            return this.UnitCommodity == ord.UnitCommodity;
        }
    }

    class OrderException : Exception
    {
        private int code;
        public OrderException(String message, int code) : base(message)
        {
            this.code = code;
        }
        public int Code { get => code; }
    }


    public class OrderService
    {
        public List<OrderItem> orders = new List<OrderItem>();
        Commodity commodities = new Commodity();

        public void createOrder(String name, String commodity, int amount, String address)
        {
            //创建客户信息
            Customer customer = new Customer();
            customer.Name = name;
            customer.Address = address;
            customer.commoditiesBought.Add(commodity);

            OrderItem order = new OrderItem();

            //创建订单明细
            OrderDetails details = new OrderDetails(commodity, amount);
            order.details.Add(details);

            //创建订单信息
            order.ID = "A" + new Random(BitConverter.ToInt32(Guid.NewGuid().ToByteArray(), 0)).Next(0, 10000000).ToString();
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
            if (!commodities.dic.ContainsKey(commodity)) throw new OrderException("修改失败，没有此商品", 4);

            foreach (OrderItem order in orders)
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
            IEnumerable<OrderItem> query = null;

            query = from s in orders
                    from q in s.customer.commoditiesBought
                    where q == info || s.customer.Name == info || s.TotalValue.ToString() == info || s.ID == info
                    orderby s.TotalValue ascending
                    select s;

            if (query.Count() == 0)
            {
                Console.WriteLine("无此订单");
                return false;
            }

            int i = 1;
            foreach (OrderItem order in query)
            {
                Console.WriteLine($"订单{i++}");
                Console.WriteLine(order.ToString() + "\n");
            }

            return true;
        }

        public void printTotalOrder()
        {
            Console.WriteLine("所有的订单如下：");
            int i = 1;
            foreach (OrderItem order in orders)
            {
                Console.WriteLine($"订单{i++}");
                Console.WriteLine(order.ToString() + "\n");
            }
        }



    }
}
