using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = ExectueTask1(10).ToString();
            label4.Text = ExectueTask2(10).ToString();

        }

        private int ExectueTask1(int num)
        {
            System.Threading.Thread.Sleep(5000);
            return num * num;
        }

        private int ExectueTask2(int num)
        {
            return num * num;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            MyCalculator objMyCal = ExectueTask1;//创建委托变量，并代表方法1

            //通过委托异步调用任务
            //委托类型的BeginInvoke（<输入和输出变量>， AsyncCallback callback，objeck asyncState）方法：异步调用的核心
            //第一个参数10，表示委托对应的实参
            //第二个参数callback：回调函数，表示异步调用后自动调用的函数
            //第三个参数asyncStatus，用于向回调函数提供参数信息
            //返回值：IAsuncResult->异步操作状态接口，封装了异步执行中的参数


            IAsyncResult result = objMyCal.BeginInvoke(10, null, null);
            this.label3.Text = "正在计算请稍等...";

            //同时执行其他任务
            this.label4.Text = ExectueTask2(5).ToString();

            //获取异步执行的结果
            int res = objMyCal.EndInvoke(result);
            this.label3.Text = res.ToString();
        }


        //[1]定义委托
        public delegate int MyCalculator(int num);


    }
}
