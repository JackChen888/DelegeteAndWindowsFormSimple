using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegeteApp2
{
    public partial class Form1 : Form
    {
        //【3】创建委托对象（委托对象能够将委托和具体的方法关联）
        public ShowCounterDelegate msgSender;
        public Form1()
        {
            InitializeComponent();
            //创建窗体
            FrmOther01 objFrm01 = new FrmOther01();
            FrmOther02 objFrm02 = new FrmOther02();
            FrmOther03 objFrm03 = new FrmOther03();
            //【4】将委托和具体的方法关联
            this.msgSender += objFrm01.Receiver;
            this.msgSender += objFrm02.Receiver;
            this.msgSender += objFrm03.Receiver;
            //显示窗体
            objFrm01.Show();
            objFrm02.Show();
            objFrm03.Show();

        }
        private int counter = 0;
        //发消息

        private void button1_Click(object sender, EventArgs e)
        {
            counter++;
            msgSender(counter.ToString());//【5】调用委托传入的信息
            //msgSender.Invoke(counter.ToString());//另一种
        }

        private void button2_Click(object sender, EventArgs e)
        {
            counter = 0;
            msgSender("0");
        }
    }

    //【1】创建委托
    public delegate void ShowCounterDelegate(string counter);

}
