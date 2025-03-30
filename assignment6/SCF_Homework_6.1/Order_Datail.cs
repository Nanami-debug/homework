using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORDER_DATAIL
{
    public class Node
    {
        public string name { get; set; }
        public int num { get; set; }
        public int cost { get; set; }//单价
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
        public List<Node> Goods;
        private int profit;
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
