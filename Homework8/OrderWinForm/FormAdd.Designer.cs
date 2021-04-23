namespace OrderWinForm
{
    partial class FormAdd
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
            this.tabControlAdd = new System.Windows.Forms.TabControl();
            this.tabPageCustomerInfo = new System.Windows.Forms.TabPage();
            this.textBoxAddr = new System.Windows.Forms.TextBox();
            this.labelAddr = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.tabPageGoodsInfo = new System.Windows.Forms.TabPage();
            this.numericAmount = new System.Windows.Forms.NumericUpDown();
            this.labelAmount = new System.Windows.Forms.Label();
            this.textBoxGoods = new System.Windows.Forms.TextBox();
            this.labelGoods = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.tabControlAdd.SuspendLayout();
            this.tabPageCustomerInfo.SuspendLayout();
            this.tabPageGoodsInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAdd
            // 
            this.tabControlAdd.Controls.Add(this.tabPageCustomerInfo);
            this.tabControlAdd.Controls.Add(this.tabPageGoodsInfo);
            this.tabControlAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlAdd.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdd.Name = "tabControlAdd";
            this.tabControlAdd.SelectedIndex = 0;
            this.tabControlAdd.Size = new System.Drawing.Size(800, 402);
            this.tabControlAdd.TabIndex = 0;
            // 
            // tabPageCustomerInfo
            // 
            this.tabPageCustomerInfo.AllowDrop = true;
            this.tabPageCustomerInfo.Controls.Add(this.textBoxAddr);
            this.tabPageCustomerInfo.Controls.Add(this.labelAddr);
            this.tabPageCustomerInfo.Controls.Add(this.labelName);
            this.tabPageCustomerInfo.Controls.Add(this.textBoxName);
            this.tabPageCustomerInfo.Location = new System.Drawing.Point(4, 25);
            this.tabPageCustomerInfo.Name = "tabPageCustomerInfo";
            this.tabPageCustomerInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCustomerInfo.Size = new System.Drawing.Size(792, 373);
            this.tabPageCustomerInfo.TabIndex = 0;
            this.tabPageCustomerInfo.Text = "顾客信息";
            this.tabPageCustomerInfo.UseVisualStyleBackColor = true;
            // 
            // textBoxAddr
            // 
            this.textBoxAddr.Location = new System.Drawing.Point(125, 112);
            this.textBoxAddr.Name = "textBoxAddr";
            this.textBoxAddr.Size = new System.Drawing.Size(100, 25);
            this.textBoxAddr.TabIndex = 3;
            // 
            // labelAddr
            // 
            this.labelAddr.AutoSize = true;
            this.labelAddr.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAddr.Location = new System.Drawing.Point(48, 112);
            this.labelAddr.Name = "labelAddr";
            this.labelAddr.Size = new System.Drawing.Size(51, 20);
            this.labelAddr.TabIndex = 2;
            this.labelAddr.Text = "地址";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelName.Location = new System.Drawing.Point(48, 59);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "姓名";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(125, 56);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 25);
            this.textBoxName.TabIndex = 0;
            // 
            // tabPageGoodsInfo
            // 
            this.tabPageGoodsInfo.Controls.Add(this.numericAmount);
            this.tabPageGoodsInfo.Controls.Add(this.labelAmount);
            this.tabPageGoodsInfo.Controls.Add(this.textBoxGoods);
            this.tabPageGoodsInfo.Controls.Add(this.labelGoods);
            this.tabPageGoodsInfo.Location = new System.Drawing.Point(4, 25);
            this.tabPageGoodsInfo.Name = "tabPageGoodsInfo";
            this.tabPageGoodsInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGoodsInfo.Size = new System.Drawing.Size(792, 373);
            this.tabPageGoodsInfo.TabIndex = 1;
            this.tabPageGoodsInfo.Text = "商品信息";
            this.tabPageGoodsInfo.UseVisualStyleBackColor = true;
            // 
            // numericAmount
            // 
            this.numericAmount.Location = new System.Drawing.Point(159, 104);
            this.numericAmount.Name = "numericAmount";
            this.numericAmount.Size = new System.Drawing.Size(120, 25);
            this.numericAmount.TabIndex = 3;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAmount.Location = new System.Drawing.Point(52, 109);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(51, 20);
            this.labelAmount.TabIndex = 2;
            this.labelAmount.Text = "数量";
            // 
            // textBoxGoods
            // 
            this.textBoxGoods.Location = new System.Drawing.Point(159, 47);
            this.textBoxGoods.Name = "textBoxGoods";
            this.textBoxGoods.Size = new System.Drawing.Size(100, 25);
            this.textBoxGoods.TabIndex = 1;
            // 
            // labelGoods
            // 
            this.labelGoods.AutoSize = true;
            this.labelGoods.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelGoods.Location = new System.Drawing.Point(52, 47);
            this.labelGoods.Name = "labelGoods";
            this.labelGoods.Size = new System.Drawing.Size(51, 20);
            this.labelGoods.TabIndex = 0;
            this.labelGoods.Text = "商品";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(297, 420);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(178, 47);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "添加订单";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.tabControlAdd);
            this.Name = "FormAdd";
            this.Text = "FormAdd";
            this.Load += new System.EventHandler(this.FormAdd_Load);
            this.tabControlAdd.ResumeLayout(false);
            this.tabPageCustomerInfo.ResumeLayout(false);
            this.tabPageCustomerInfo.PerformLayout();
            this.tabPageGoodsInfo.ResumeLayout(false);
            this.tabPageGoodsInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAdd;
        private System.Windows.Forms.TabPage tabPageCustomerInfo;
        private System.Windows.Forms.Label labelAddr;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TabPage tabPageGoodsInfo;
        private System.Windows.Forms.TextBox textBoxAddr;
        private System.Windows.Forms.NumericUpDown numericAmount;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox textBoxGoods;
        private System.Windows.Forms.Label labelGoods;
        private System.Windows.Forms.Button buttonAdd;
    }
}