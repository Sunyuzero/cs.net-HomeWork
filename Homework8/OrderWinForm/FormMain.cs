using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace OrderWinForm
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public static OrderService Service;
        public static int ID = 0;

        private void FormMain_Load(object sender, EventArgs e)
        {
            Service = new OrderService();
        }

        private void MenuItemAdd_Click(object sender, EventArgs e)
        {
            new FormAdd().ShowDialog();
        }

        private void MenuItemDelete_Click(object sender, EventArgs e)
        {
            String info = Interaction.InputBox("请输入要删除的订单信息\n(如订单号，顾客名等等)", "输入字符串", "", 100, 100);
            Service.deleteOrder(info);
        }

        private void MenuItemModify_Click(object sender, EventArgs e)
        {

        }
    }
}
