using Microsoft.VisualBasic;
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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public static int ID = 0;
        public static int customerID = 0;

        public static OrderService Service = new OrderService();
        public Order order;

        private void FormMain_Load(object sender, EventArgs e)
        {
            cmb_search.Items.Add("订单号");
            cmb_search.Items.Add("客户名称");
            cmb_search.Items.Add("总金额");
            cmb_search.Items.Add("商品名称");

            OrderbindingSource.DataSource = Service.orders;
            
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            FormModifyandAdd modifyForm = new FormModifyandAdd();
            modifyForm.modifyInfo();
            modifyForm.ShowDialog();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            String info = Interaction.InputBox("请输入顾客姓名", "输入字符串", "", 100, 100);
            Customer customer = new Customer(customerID++, info);
            order = new Order(ID++, customer, DateTime.Now);
            FormModifyandAdd formAdd = new FormModifyandAdd();
            formAdd.addInfo(order);
            Service.AddOrder(order);
            formAdd.ShowDialog();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            switch (cmb_search.Text)
            {
                case "订单号":
                    Service.GetById(Int32.Parse(tb_search.Text));
                    break;
                case "顾客名称":
                    Service.QueryByCustomerName(tb_search.Text);
                    break;
                case "总金额":
                    Service.QueryByTotalAmount(float.Parse(tb_search.Text));
                    break;
                case "商品名称":
                    Service.QueryByGoodsName(tb_search.Text);
                    break;
                default:
                    break;
            }
        }

        private void dataGridView_Order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            orderDetailBindingSource.DataSource = Service.orders[dataGridView_Order.SelectedRows.Count].Details;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            String info = Interaction.InputBox("请输入要删除的订单号", "输入字符串", "", 100, 100);
            int deleteId = int.Parse(info);
            Service.RemoveOrder(deleteId);
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            String path = Interaction.InputBox("请输入导出订单的路径", "输入字符串", "", 100, 100);
            Service.Export(path);
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            String path = Interaction.InputBox("请输入导入订单的路径", "输入字符串", "", 100, 100);
            Service.Import(path);
        }
    }
}
