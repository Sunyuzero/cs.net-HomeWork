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

        public OrderDetails() { }
        public override string ToString()
        {
            return commodity.ToString()+"total：" + Amount;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is OrderDetails)) throw new ArgumentException();
            OrderDetails ord = (OrderDetails)obj;
            return this.UnitCommodity == ord.UnitCommodity;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
