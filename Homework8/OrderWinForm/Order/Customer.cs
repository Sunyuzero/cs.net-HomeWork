using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderWinForm
{
    public class Customer
    {
        public Customer() { }
        public Customer(String name, String commoditiesBought, String address)
        {
            this.Name = name;
            this.CommoditiesBought = commoditiesBought;
            this.Address = address;
        }
        public String Name { get; set; }

        public String CommoditiesBought { get; set; }

        public String Address { get; set; }
        public override string ToString()
        {
            String str = CommoditiesBought;
            return "[ name：" + Name + " ， " + "buy：" + str + "]";
        }
    }
}
