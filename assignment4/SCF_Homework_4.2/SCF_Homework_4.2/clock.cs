using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClock
{
    public delegate void Tick(object sender,int n=60);
    public delegate void Alarm(object sender,int count);
    internal class clock
    {
        public int time { get; set; }
        public bool mode { get; set; }
        public event Tick tick;
        public event Alarm alarm;
        
        public clock()
        {
            time = 0;
            mode = false;
        }
        public void open(int n=60)
        {
            mode = true;
            
            //开始走时
            tick(this,n);
        }
        public void close()
        {
            mode = false;
            time = 0;
            //结束走时
        }
        public void alarm_after(int n)
        {
            mode = true;
            alarm(this,n);
            close();
        }
    }
}
