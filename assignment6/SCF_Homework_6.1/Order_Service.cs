using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ORDER;
using ORDER_DATAIL;

namespace ORDER_SERVICE
{
    public class Order_Service
    {
        public List<Order> orders;
        public int count;
        public Order_Service() { orders = new List<Order>();count = 0; }
        public int Add_Order(string name)
        {
            count++;
            Order order = new Order(count, name);
            orders.Add(order);
            return count;
        }
       public bool id_and_name(int id,string name)
        {
            if (orders.Count == 0) return false;
            foreach (Order order in orders)
            {
                if(order.id==id)
                    return true ? order.name == name : false;
            }
            return false;
        }
        public void Remove_Order(int id) 
        {
            if (orders.Count == 0) return;
            orders.RemoveAll(n=>n.id==id); 
        }
        public List<Order> Get_Order(string name)
        {
            List<Order> my_order=new List<Order>();
            foreach (Order order in orders)
            {
                if (order.name==name)
                {
                    my_order.Add(order);
                }
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
            foreach(Order o in orders )
            {
                if (o.id==id)
                {
                    p = o.datail.get_profit();
                }
            }
            return p;
        }
    }
}
