namespace OrderWinForm
{
    partial class FormModifyandAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_ID = new System.Windows.Forms.Label();
            this.cmb_name = new System.Windows.Forms.ComboBox();
            this.label_name1 = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_details = new System.Windows.Forms.DataGridView();
            this.label_details = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label_info = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tc_AddorModify = new System.Windows.Forms.TabControl();
            this.tb_add = new System.Windows.Forms.TabPage();
            this.label_addTime = new System.Windows.Forms.Label();
            this.label_addId = new System.Windows.Forms.Label();
            this.label_AddName = new System.Windows.Forms.Label();
            this.tb_modify = new System.Windows.Forms.TabPage();
            this.goodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_details)).BeginInit();
            this.tc_AddorModify.SuspendLayout();
            this.tb_add.SuspendLayout();
            this.tb_modify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ID.Location = new System.Drawing.Point(34, 27);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(72, 20);
            this.label_ID.TabIndex = 1;
            this.label_ID.Text = "订单号";
            // 
            // cmb_name
            // 
            this.cmb_name.FormattingEnabled = true;
            this.cmb_name.Location = new System.Drawing.Point(114, 66);
            this.cmb_name.Name = "cmb_name";
            this.cmb_name.Size = new System.Drawing.Size(340, 23);
            this.cmb_name.TabIndex = 2;
            // 
            // label_name1
            // 
            this.label_name1.AutoSize = true;
            this.label_name1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_name1.Location = new System.Drawing.Point(34, 65);
            this.label_name1.Name = "label_name1";
            this.label_name1.Size = new System.Drawing.Size(72, 20);
            this.label_name1.TabIndex = 3;
            this.label_name1.Text = "顾客名";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(111, 103);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(67, 15);
            this.label_time.TabIndex = 4;
            this.label_time.Text = "下单时间";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_details);
            this.panel1.Location = new System.Drawing.Point(3, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 185);
            this.panel1.TabIndex = 5;
            // 
            // dgv_details
            // 
            this.dgv_details.AutoGenerateColumns = false;
            this.dgv_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodsDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.dgv_details.DataSource = this.orderDetailBindingSource;
            this.dgv_details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_details.Location = new System.Drawing.Point(0, 0);
            this.dgv_details.Name = "dgv_details";
            this.dgv_details.RowHeadersWidth = 51;
            this.dgv_details.RowTemplate.Height = 27;
            this.dgv_details.Size = new System.Drawing.Size(796, 185);
            this.dgv_details.TabIndex = 0;
            // 
            // label_details
            // 
            this.label_details.AutoSize = true;
            this.label_details.Location = new System.Drawing.Point(3, 160);
            this.label_details.Name = "label_details";
            this.label_details.Size = new System.Drawing.Size(67, 15);
            this.label_details.TabIndex = 6;
            this.label_details.Text = "订单明细";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(13, 373);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(129, 45);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "添加明细";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_modify
            // 
            this.btn_modify.Location = new System.Drawing.Point(174, 373);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(128, 45);
            this.btn_modify.TabIndex = 8;
            this.btn_modify.Text = "修改明细";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(343, 373);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(115, 45);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "删除明细";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Location = new System.Drawing.Point(-1, 3);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(67, 15);
            this.label_info.TabIndex = 11;
            this.label_info.Text = "基本信息";
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(114, 27);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(340, 25);
            this.tb_ID.TabIndex = 12;
            // 
            // tc_AddorModify
            // 
            this.tc_AddorModify.Controls.Add(this.tb_add);
            this.tc_AddorModify.Controls.Add(this.tb_modify);
            this.tc_AddorModify.Dock = System.Windows.Forms.DockStyle.Top;
            this.tc_AddorModify.Location = new System.Drawing.Point(0, 0);
            this.tc_AddorModify.Name = "tc_AddorModify";
            this.tc_AddorModify.SelectedIndex = 0;
            this.tc_AddorModify.Size = new System.Drawing.Size(800, 150);
            this.tc_AddorModify.TabIndex = 13;
            // 
            // tb_add
            // 
            this.tb_add.Controls.Add(this.label_addTime);
            this.tb_add.Controls.Add(this.label_addId);
            this.tb_add.Controls.Add(this.label_AddName);
            this.tb_add.Location = new System.Drawing.Point(4, 25);
            this.tb_add.Name = "tb_add";
            this.tb_add.Padding = new System.Windows.Forms.Padding(3);
            this.tb_add.Size = new System.Drawing.Size(792, 121);
            this.tb_add.TabIndex = 0;
            this.tb_add.Text = "添加订单";
            this.tb_add.UseVisualStyleBackColor = true;
            // 
            // label_addTime
            // 
            this.label_addTime.AutoSize = true;
            this.label_addTime.Location = new System.Drawing.Point(86, 94);
            this.label_addTime.Name = "label_addTime";
            this.label_addTime.Size = new System.Drawing.Size(67, 15);
            this.label_addTime.TabIndex = 2;
            this.label_addTime.Text = "下单时间";
            // 
            // label_addId
            // 
            this.label_addId.AutoSize = true;
            this.label_addId.Location = new System.Drawing.Point(86, 54);
            this.label_addId.Name = "label_addId";
            this.label_addId.Size = new System.Drawing.Size(52, 15);
            this.label_addId.TabIndex = 1;
            this.label_addId.Text = "订单号";
            // 
            // label_AddName
            // 
            this.label_AddName.AutoSize = true;
            this.label_AddName.Location = new System.Drawing.Point(86, 17);
            this.label_AddName.Name = "label_AddName";
            this.label_AddName.Size = new System.Drawing.Size(52, 15);
            this.label_AddName.TabIndex = 0;
            this.label_AddName.Text = "顾客名";
            // 
            // tb_modify
            // 
            this.tb_modify.Controls.Add(this.label_info);
            this.tb_modify.Controls.Add(this.label_time);
            this.tb_modify.Controls.Add(this.label_ID);
            this.tb_modify.Controls.Add(this.tb_ID);
            this.tb_modify.Controls.Add(this.label_name1);
            this.tb_modify.Controls.Add(this.cmb_name);
            this.tb_modify.Location = new System.Drawing.Point(4, 25);
            this.tb_modify.Name = "tb_modify";
            this.tb_modify.Padding = new System.Windows.Forms.Padding(3);
            this.tb_modify.Size = new System.Drawing.Size(792, 121);
            this.tb_modify.TabIndex = 1;
            this.tb_modify.Text = "修改订单";
            this.tb_modify.UseVisualStyleBackColor = true;
            // 
            // goodsDataGridViewTextBoxColumn
            // 
            this.goodsDataGridViewTextBoxColumn.DataPropertyName = "Goods";
            this.goodsDataGridViewTextBoxColumn.HeaderText = "Goods";
            this.goodsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodsDataGridViewTextBoxColumn.Name = "goodsDataGridViewTextBoxColumn";
            this.goodsDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderDetailBindingSource
            // 
            this.orderDetailBindingSource.DataSource = typeof(OrderWinForm.OrderDetail);
            // 
            // FormModifyandAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tc_AddorModify);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_modify);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label_details);
            this.Controls.Add(this.panel1);
            this.Name = "FormModifyandAdd";
            this.Text = "FormModifyandAdd";
            this.Load += new System.EventHandler(this.FormModify_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_details)).EndInit();
            this.tc_AddorModify.ResumeLayout(false);
            this.tb_add.ResumeLayout(false);
            this.tb_add.PerformLayout();
            this.tb_modify.ResumeLayout(false);
            this.tb_modify.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.ComboBox cmb_name;
        private System.Windows.Forms.Label label_name1;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_details;
        private System.Windows.Forms.Label label_details;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.TabControl tc_AddorModify;
        private System.Windows.Forms.TabPage tb_add;
        private System.Windows.Forms.Label label_addTime;
        private System.Windows.Forms.Label label_addId;
        private System.Windows.Forms.Label label_AddName;
        private System.Windows.Forms.TabPage tb_modify;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderDetailBindingSource;
    }
}