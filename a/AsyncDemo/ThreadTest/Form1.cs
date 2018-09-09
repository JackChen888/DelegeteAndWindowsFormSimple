using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadTest
{
    public partial class Form1 : Form
    {
        //多线程
        public Form1()
        {
            InitializeComponent();
        }



        private void but_Execute1_Click(object sender, EventArgs e)
        {
            Thread objThread1 = new Thread(delegate()//匿名方法创建线程
            {
                for (int i = 0; i <= 50; i++)
                {
                    Console.WriteLine("第一个线程的第" + i + "条数据");
                    Thread.Sleep(100);
                }
            });
            objThread1.IsBackground = true;
            objThread1.Start();
        }

        private void but_Execute2_Click(object sender, EventArgs e)
        {
            Thread objThread2 = new Thread(() =>
                {
                    for (int i = 0; i < 1000; i++)
                    {
                        Console.WriteLine("第二个线程的第" + i + "条数据");
                        Thread.Sleep(10);
                    }
                }
                );
            objThread2.IsBackground = true;
            objThread2.Start();


        }
    }
}
