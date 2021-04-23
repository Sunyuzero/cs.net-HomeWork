using Microsoft.VisualBasic;
using OrderWinForm.orders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderWinForm
{
    public partial class FormModifyandAdd : Form
    {
        public FormModifyandAdd()
        {
            InitializeComponent();
        }

        public static int DetailID = 0;
        public static stone GoodsStone = new stone(); 
        public Order addOrder = new Order();
        public Order modifyOrder = new Order();
        public OrderDetail detail = new OrderDetail();
        public Customer customer = new Customer();

        public void addInfo(Order order)
        {
            addOrder = order;
            label_AddName.DataBindings.Add("Text", addOrder.Customer, "Name");
            label_addId.DataBindings.Add("Text", addOrder, "Id");
            label_addTime.DataBindings.Add("Text", addOrder, "CreateTime");
        }

        public void modifyInfo()
        {
            tb_ID.DataBindings.Add("Text", modifyOrder, "Id");
            modifyOrder = FormMain.Service.GetById(modifyOrder.Id);
            cmb_name.DataBindings.Add("SelectedItem", modifyOrder.Customer, "Name");
            label_time.DataBindings.Add("Text", modifyOrder, "CreateTime");
        }

        private void FormModify_Load(object sender, EventArgs e)
        {
            modifyOrder = new Order();

            foreach(Order order in FormMain.Service.orders)
            {
                cmb_name.Items.Add(order.Customer.Name);
            }

            dgv_details.DataSource = modifyOrder.Details; 
        }

        public OrderDetail detailInfo()
        {
            OrderDetail detail = new OrderDetail();
            String goodName = Interaction.InputBox("请输入购买的商品", "输入字符串", "", 100, 100);
            int quantity = int.Parse(Interaction.InputBox("请输入购买的数量", "输入字符串", "", 100, 100));
            Goods good = GoodsStone.GetGoods(goodName);
            detail.Quantity = quantity;
            detail.Goods = good;
            return detail;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            detail = detailInfo();
            modifyOrder.AddDetails(detail);
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            detail = detailInfo();
            modifyOrder.Details.RemoveAt(dgv_details.SelectedRows.Count);
            modifyOrder.Details.Add(detail);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            modifyOrder.Details.RemoveAt(dgv_details.SelectedRows.Count);
        }
    }
}
