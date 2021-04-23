using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderWinForm
{
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();     
        }

        private Order order;
        private Customer customer;
        private OrderDetails details;

        private void FormAdd_Load(object sender, EventArgs e)
        {
            order = new Order();
            customer = new Customer();
            details = new OrderDetails();

            textBoxName.DataBindings.Add("Text", customer, "Name");
            textBoxAddr.DataBindings.Add("Text", customer, "Address");
            textBoxGoods.DataBindings.Add("Text", details, "UnitCommodity");
            numericAmount.DataBindings.Add("Value", details, "Amount");

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormMain.Service.createOrder(FormMain.ID, customer.Name, details.UnitCommodity, details.Amount, customer.Address);
            FormMain.ID++;

            MessageBoxButtons Mesbtn = MessageBoxButtons.OK;
            DialogResult AddResult = MessageBox.Show("添加成功", "回到主界面", Mesbtn);
            if(AddResult == DialogResult.OK) Application.OpenForms["FormAdd"].Close();
        }
    }
}
