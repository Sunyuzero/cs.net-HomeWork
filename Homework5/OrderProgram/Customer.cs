using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProgram
{
    public class Customer
    {
        public String Name { get; set; }

        public List<String> commoditiesBought = new List<string>();

        public String Address { get; set; }
        public override string ToString()
        {
            String str = "";
            foreach(String commodity in commoditiesBought)
            {
                str = str + commodity + " ";
            }
            return "[ name：" + Name + " ， " + "buy：" + str + "]";
        }
    }
}
