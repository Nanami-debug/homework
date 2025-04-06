using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ORDER;
using ORDER_DATAIL;
using Myd;
using Microsoft.EntityFrameworkCore;

namespace ORDER_SERVICE
{
    public class Order_Service
    {
        
        public List<Order> orders;
        public int count;
        public Order_Service() { orders = new List<Order>(); count = 0; }
            
        public int Add_Order(string name)
        {
            count++;
            Order order = new Order(count, name);
            orders.Add(order);
            return count;
        }
       public bool id_and_name(int id,string name)
        {
            int count0 = 0;
            using (var context=new MyDB())
            {
                count0 = context.Orders.Count();
            }
                Order order = new Order(count0, name);
            if (count0 == 0) return false;
            using (var context = new MyDB())
            {
                    order = context.Orders
                    .Single(o => o.id == id);
            }
            if (order.name==name)return true;
            return false;
        }
        public void Remove_Order(int id) 
        {
            int count0 = 0;
            using (var context = new MyDB())
            {
                count0 = context.Orders.Count();
            }
            if (count0 == 0) return;
            using (var context = new MyDB())
            {
                // 查询要删除的记录
                var order = context.Orders
                    .FirstOrDefault(o => o.id == id);

                if (order != null)
                {
                    // 删除记录
                    context.Orders.Remove(order);
                    context.SaveChanges(); // 保存更改
                }
            }


        }
        public List<Order> Get_Order(string _name)
        {
            List<Order> my_order=new List<Order>();
            using (var context = new MyDB())
            {
                // 查询OrderName为"Order 1"的所有订单
                my_order = context.Orders
                    .Where(o => o.name == _name)
                    .Include(o => o.datail) // 加载Order_Detail
                    .ThenInclude(d => d.Goods) // 加载Node
                    .ToList();
            }
            return my_order;
        }
        public void add_order_datail(int id, string name0, int num,int cost)
        {
            foreach (Order order in orders)
            {
                if (order.id == id)
                {
                    order.datail.Goods.Add(new Node(name0, num, cost));
                }
            }
        }
        public void change_Order_Datail(int id,string name0,int num,int cost)
        {
            foreach(Order a in orders)
            {
                if(a.id==id)
                {
                    Node _node = new Node(name0,num,cost);
                    a.datail.Goods.RemoveAll(n=>n.name==name0);
                    a.datail.Goods.Add(_node);
                    return;
                }
            }   
        }

        public int get_Profit(int id)
        {
            int p = 0;
            Order order;
            using (MyDB db = new MyDB())
            {
                order = db.Orders
                        .Include(o => o.datail)
                        .ThenInclude(d => d.Goods)
                        .First(o=>o.id==id);
            }
            p = order.datail.get_profit();
            return p;
        }
    }
}
