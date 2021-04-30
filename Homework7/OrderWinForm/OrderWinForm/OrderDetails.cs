using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrderWinForm
{
    public class OrderDetails
    {
        public OrderDetails() { }
        public OrderDetails(String unitCommodity, int amount)
        {
            this.UnitCommodity = unitCommodity;
            this.Amount = amount;
        }
        public Commodity commodity = new Commodity();
        public String UnitCommodity { get; set; }
        public int Amount { get; set; }
        public double UnitTotalValue { get => Amount * commodity.dic[UnitCommodity]; }

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

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
