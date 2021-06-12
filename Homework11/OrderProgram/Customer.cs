using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProgram
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
    public class CustomerContext : DbContext
    {
        public CustomerContext() : base("CustomerDataBase")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<OrderContext>());
        }

        public DbSet<Customer> customers { get; set; }
    }
}
