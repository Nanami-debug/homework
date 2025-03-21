using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ORDER_DATAIL;

namespace ORDER
{
    internal class Order
    {
        internal int id;//订单编号
        internal DateTime time;//订单创建时间
        internal string name;//订单的创建人
        internal Order_Datail datail;//订单明细
        public Order(int id,string name) 
        {
            this.id = id;
            this.time = DateTime.Now;
            this.name = name;
            datail = new Order_Datail();
        }
        
        public override bool Equals(object? obj)
        {
            return obj is Order order &&
                   id == order.id &&
                   time == order.time &&
                   name == order.name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id, time, name);
        }

        public override string ToString()
        {
            return $"订单id:{id} 订单创建时间:{time} 订单创建人:{name}\n" +
                $"订单明细为\n"+datail.ToString();
        }
    }
}
