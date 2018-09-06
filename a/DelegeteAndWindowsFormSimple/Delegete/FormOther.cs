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
    public partial class FormOther : Form
    {
        public FormOther()
        {
            InitializeComponent();
        }

        public ShowCounterDelegate msgSender;

        private int counter = 0;//计数器

        private void button1_Click(object sender, EventArgs e)
        {
            counter++;
            if (msgSender != null)
            {
                msgSender(counter.ToString());
            }
        }
    }
}
