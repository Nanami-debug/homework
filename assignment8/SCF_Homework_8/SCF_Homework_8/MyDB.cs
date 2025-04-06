using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ORDER;
using ORDER_DATAIL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using MySql.EntityFrameworkCore.Extensions;

namespace Myd
{
    public class MyDB:DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Order_Datail> Order_Details { get; set; }
        public DbSet<Node> Nodes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 配置Order和Order_Detail的一对一关系
            modelBuilder.Entity<Order>()
                .HasOne(o => o.datail) // Order有一个Order_Detail
                .WithOne(d => d.Order) // Order_Detail关联一个Order
                .HasForeignKey<Order_Datail>(d => d.OrderId) // 外键
                .OnDelete(DeleteBehavior.Cascade); // 级联删除

            // 配置Order_Detail和Node的一对多关系
            modelBuilder.Entity<Order_Datail>()
                .HasMany(d => d.Goods) // Order_Detail有多个Node
                .WithOne(n => n.Order_Detail) // Node关联一个Order_Detail
                .HasForeignKey(n => n.Order_DetailId) // 外键
                .OnDelete(DeleteBehavior.Cascade); // 级联删除
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=_order;user=root;password=744735631qaws;");
        }
    }

}

