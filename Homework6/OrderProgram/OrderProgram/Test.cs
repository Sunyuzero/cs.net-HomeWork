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


                //创建测试订单，测试export
                service.createOrder("TOM", "apple", 2, "Address");
                System.Threading.Thread.Sleep(1000);
                service.createOrder("TOM", "banana", 10, "Luoyu");
                service.createOrder("TOM", "banana", 3, "Luoyu1");
                service.createOrder("TOM", "banana", 8, "Luoyu2");
                service.export();
            

            //import测试
            /*
                service.printTotalOrder();
                service.import();
                service.printTotalOrder();
            */

            Console.ReadLine();

        }
    }
}
