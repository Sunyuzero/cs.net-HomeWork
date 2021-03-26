using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrderProgram
{
    public class OrderDetails
    {
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
            return commodity.ToString()+"total：" + Amount;
        }

    }
}
