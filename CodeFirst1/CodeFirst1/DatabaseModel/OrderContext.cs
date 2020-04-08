using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace CodeFirst1.DatabaseModel
{
    public class OrderContext :DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options):base(options)
        {

        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
