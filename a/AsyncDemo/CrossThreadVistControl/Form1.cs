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

namespace CrossThreadVistControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //跨线程访问可视化控件
        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            Thread objThread = new Thread(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    a += i;
                    if (this.label1.InvokeRequired)//判断是否调用invoke方法
                    {
                        //Invoke(方法)第一个参数是返回值为void的委托，第二个是给委托对应的方法传递参数的
                        this.label1.Invoke(new Action<string>(s => { this.label1.Text = s; }), a.ToString());
                    }
                    Thread.Sleep(200);
                }
            });
            objThread.IsBackground = true;
            objThread.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 0;
            Thread objThread2 = new Thread(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    a += i;
                    if (this.label2.InvokeRequired)//判断是否调用invoke方法
                    {
                        //Invoke(方法)第一个参数是返回值为void的委托，第二个是给委托对应的方法传递参数的
                        this.label2.Invoke(new Action<string>(s => { this.label2.Text = s; }), a.ToString());
                    }
                    Thread.Sleep(1000);
                }
            });
            objThread2.IsBackground = true;
            objThread2.Start();
        }
    }
}
