using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClock;
namespace MyForm
{
    internal class Form
    {
        public clock clock1 = new clock();
        public  Form()
        {
            clock1.tick += tick_open;
            clock1.alarm+=alarm_open;
        }
        void tick_open(object sender, int n)
        {
            Console.Write("开始走时\n");
            while (clock1.mode && clock1.time <= n)
            {
                Console.WriteLine("滴答...");
                clock1.time++;
            }
        }
        void alarm_open(object sender, int n)
        {
            Console.Write("开始走时\n");
            while (clock1.mode)
            {
                Console.WriteLine("滴答...");
                clock1.time++;
                if (clock1.time == n)
                {
                    Console.WriteLine("\n叮零零零零，时间到了");
                    break;
                }   
            }
        }
    }
}
