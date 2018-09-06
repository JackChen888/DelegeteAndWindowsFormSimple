using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncCallbackDemo
{
    public partial class Form1 : Form
    {
        //异步回调
        public Form1()
        {
            InitializeComponent();

            this.objMyCal = new MyCalculator(ExecuteTask);
        }

        //2根据委托定义方法
        private int ExecuteTask(int num, int ms)
        {
            System.Threading.Thread.Sleep(ms);
            return num * num;

        }
        MyCalculator objMyCal = null;

        private void button1_Click(object sender, EventArgs e)
        {
           
          Random c = new Random();
            for (int i = 0; i < 11; i++)
            {
                
                int num = c.Next(10);
                objMyCal.BeginInvoke(10 * i, 1000 * num, MyCallBack, i);
            }
        }

        private void MyCallBack(IAsyncResult result)
        {
            int res = objMyCal.EndInvoke(result);

            //异步显示结果
            Console.WriteLine("第{0}个计算结果为：{1}", result.AsyncState, res.ToString());

        }

    }

    //1声明一个委托
    public delegate int MyCalculator(int num,int ms);


}
