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
            OrderService service = new OrderService();

            Console.WriteLine("已有的商品为：");
            Console.WriteLine(new Commodity().ToString());

            //创建测试订单
            service.createOrder("TOM", "apple", 2, "Address");
            System.Threading.Thread.Sleep(1000);
            service.createOrder("TOM", "banana", 10, "Luoyu");
            service.createOrder("TOM", "banana", 3, "Luoyu1");
            service.createOrder("TOM", "banana", 8, "Luoyu2");

            service.orders.Sort();
            service.printTotalOrder();
            service.orders.Sort((o1,o2) => (int)(o1.TotalValue -o2.TotalValue));
            service.printTotalOrder();

            Console.Write("搜索订单(请输入要查询的订单号/总金额/顾客姓名/购买的东西)：");
            String s1 = Console.ReadLine();
            service.searchOrder(s1);


            try
            {
                Console.Write("删除订单(请输入要查询的订单号/总金额/顾客姓名/购买的东西)");
                String s0 = Console.ReadLine();
                service.deleteOrder(s0);

                Console.Write("输入要修改的订单的订单号：");
                String s2 = Console.ReadLine();
                service.modifyOrder(s2);

                service.printTotalOrder();
            }
            catch(OrderException e)
            {
                Console.WriteLine("\n操作失败，错误代码：" + e.Code);
            }

            
            Console.ReadLine();

        }
    }
}
