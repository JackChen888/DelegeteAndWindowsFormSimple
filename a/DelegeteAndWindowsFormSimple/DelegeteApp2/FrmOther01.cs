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
    public partial class FrmOther01 : Form
    {
        public FrmOther01()
        {
            InitializeComponent();
        }
        //【2】根据委托定义方法（接受委托传递的信息）
        public void Receiver(string counter)
        {
            this.label1.Text = counter;
        }

    }
}
