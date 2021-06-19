using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;

namespace Order.Models
{
    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options)
            : base(options)
        {
        }

        public DbSet<OrderItem> TodoItems { get; set; }
    }
}