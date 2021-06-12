using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProgram
{
    public class OrderContext:DbContext
    {
        public OrderContext() : base("OrderDataBase")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<OrderContext>());
        }

        public DbSet<Order> orders { get; set; }
        public DbSet<OrderDetails> details { get; set; }
   
    }
}
