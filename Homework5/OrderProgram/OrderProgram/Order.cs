using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProgram
{
    public class Order:IComparable
    {
        public String ID { get; set; }
        public Customer customer { get; set; }
        public String Time { get; set; }
        public double TotalValue { get; set; }

        public List <OrderDetails> details = new List<OrderDetails>();

        public override string ToString() 
        {
            return "  ID：" + ID + " \n " + " TotalValue：" + TotalValue + "  \n " +
                          " Time：" + Time + " \n " +  " customer：" + customer ;
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Order)) throw new System.ArgumentException();
            Order ord = (Order)obj;
            return this.ID.CompareTo(ord.ID);
        }

       
        
    }
}
