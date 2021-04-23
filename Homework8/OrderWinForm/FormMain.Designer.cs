namespace OrderWinForm
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemModify = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemImport = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemExport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // Menu
            // 
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAdd,
            this.MenuItemDelete,
            this.MenuItemModify,
            this.MenuItemSearch,
            this.MenuItemImport,
            this.MenuItemExport});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(53, 24);
            this.Menu.Text = "菜单";
            // 
            // MenuItemAdd
            // 
            this.MenuItemAdd.Name = "MenuItemAdd";
            this.MenuItemAdd.Size = new System.Drawing.Size(224, 26);
            this.MenuItemAdd.Text = "添加订单";
            this.MenuItemAdd.Click += new System.EventHandler(this.MenuItemAdd_Click);
            // 
            // MenuItemDelete
            // 
            this.MenuItemDelete.Name = "MenuItemDelete";
            this.MenuItemDelete.Size = new System.Drawing.Size(224, 26);
            this.MenuItemDelete.Text = "删除订单";
            this.MenuItemDelete.Click += new System.EventHandler(this.MenuItemDelete_Click);
            // 
            // MenuItemModify
            // 
            this.MenuItemModify.Name = "MenuItemModify";
            this.MenuItemModify.Size = new System.Drawing.Size(224, 26);
            this.MenuItemModify.Text = "修改订单";
            this.MenuItemModify.Click += new System.EventHandler(this.MenuItemModify_Click);
            // 
            // MenuItemSearch
            // 
            this.MenuItemSearch.Name = "MenuItemSearch";
            this.MenuItemSearch.Size = new System.Drawing.Size(224, 26);
            this.MenuItemSearch.Text = "查询订单";
            // 
            // MenuItemImport
            // 
            this.MenuItemImport.Name = "MenuItemImport";
            this.MenuItemImport.Size = new System.Drawing.Size(224, 26);
            this.MenuItemImport.Text = "导入订单";
            // 
            // MenuItemExport
            // 
            this.MenuItemExport.Name = "MenuItemExport";
            this.MenuItemExport.Size = new System.Drawing.Size(224, 26);
            this.MenuItemExport.Text = "导出订单";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.Text = "主界面";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAdd;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDelete;
        private System.Windows.Forms.ToolStripMenuItem MenuItemModify;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSearch;
        private System.Windows.Forms.ToolStripMenuItem MenuItemImport;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExport;
    }
}

