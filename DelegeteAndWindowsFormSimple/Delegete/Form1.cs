using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 委托实现页面传值
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormOther objFrm = new FormOther();
            objFrm.msgSender = this.Receiver;
            objFrm.Show();
        }

        private void Receiver(string counter)
        {
            this.label1.Text = counter;
        }
    }
    public delegate void ShowCounterDelegate(string counter);
}
