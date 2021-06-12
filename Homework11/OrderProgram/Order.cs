using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProgram
{
    public class Order : IComparable
    {
        public Order() { }
        public Order(int id, Customer customer, DateTime date)
        {
            this.ID = id;
            this.Customer = customer;
            this.Time = date;
        }
        public int ID { get; set; }
        public Customer Customer { get; set; }
        public DateTime Time { get; set; }
        public double TotalValue { get; set; }

        public List<OrderDetails> Details = new List<OrderDetails>();
        public void addDetails(OrderDetails details)
        {
            Details.Add(details);
        }

        public override string ToString()
        {
            return "  ID：" + ID + " \n " + " TotalValue：" + TotalValue + "  \n " +
                          " Time：" + Time.ToString() + " \n " + " customer：" + Customer;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Order)) throw new ArgumentException();
            Order ord = (Order)obj;
            return this.ID == ord.ID;
        }
        public int CompareTo(object obj)
        {
            if (!(obj is Order)) throw new System.ArgumentException();
            Order ord = (Order)obj;
            return this.ID.CompareTo(ord.ID);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


    }
}
