using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ORDER;
using System.ComponentModel.DataAnnotations;

namespace ORDER_DATAIL
{
    public class Node
    {
        [Key]
        public string name { get; set; }
        public int num { get; set; }
        public int cost { get; set; }//单价
        public int Order_DetailId { get; set; } // 外键，关联Order_Detail
        public Order_Datail Order_Detail { get; set; } // 导航属性
        public Node(string name,int num,int cost)
        {
            this.name = name;
            this.num = num;
            this.cost = cost;
        }
        public override string ToString() 
        {
            return $"商品名{this.name} 数量{num} 单价{cost}\n";
        }

    }
    public class Order_Datail
    {
        [Key]
        public int Order_DetailId { get; set; }
        public List<Node> Goods;
        private int profit;
        public int OrderId { get; set; } // 外键，关联Order
        public Order Order { get; set; } // 导航属性
        public Order_Datail() 
        {
            Goods = new List<Node>();
            profit = 0;
        }
        public int get_profit()
        {
            if(Goods.Count==0) return 0;
            profit = Goods.Sum(s => s.cost * s.num);
            return profit;
        }

        public override string? ToString()
        {
            string s = "";
            foreach(Node node in Goods)
            {
                s += node.ToString();
            }
            return s;
        }
    }
}
