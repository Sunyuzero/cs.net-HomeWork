namespace crawlerWinForm
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tb_URL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_urls = new System.Windows.Forms.DataGridView();
            this.urlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource_Urls = new System.Windows.Forms.BindingSource(this.components);
            this.label_info = new System.Windows.Forms.Label();
            this.btn_end = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_urls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Urls)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_URL
            // 
            this.tb_URL.Location = new System.Drawing.Point(205, 50);
            this.tb_URL.Name = "tb_URL";
            this.tb_URL.Size = new System.Drawing.Size(556, 25);
            this.tb_URL.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "请输入要爬取的网站";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(103, 373);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(139, 45);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "开始爬取";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_crawer_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_urls);
            this.panel1.Location = new System.Drawing.Point(44, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 255);
            this.panel1.TabIndex = 3;
            // 
            // dgv_urls
            // 
            this.dgv_urls.AutoGenerateColumns = false;
            this.dgv_urls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_urls.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urlDataGridViewTextBoxColumn,
            this.infoDataGridViewTextBoxColumn});
            this.dgv_urls.DataSource = this.bindingSource_Urls;
            this.dgv_urls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_urls.Location = new System.Drawing.Point(0, 0);
            this.dgv_urls.Name = "dgv_urls";
            this.dgv_urls.ReadOnly = true;
            this.dgv_urls.RowHeadersWidth = 51;
            this.dgv_urls.RowTemplate.Height = 27;
            this.dgv_urls.Size = new System.Drawing.Size(564, 255);
            this.dgv_urls.TabIndex = 0;
            // 
            // urlDataGridViewTextBoxColumn
            // 
            this.urlDataGridViewTextBoxColumn.DataPropertyName = "url";
            this.urlDataGridViewTextBoxColumn.Frozen = true;
            this.urlDataGridViewTextBoxColumn.HeaderText = "url";
            this.urlDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urlDataGridViewTextBoxColumn.Name = "urlDataGridViewTextBoxColumn";
            this.urlDataGridViewTextBoxColumn.ReadOnly = true;
            this.urlDataGridViewTextBoxColumn.Width = 250;
            // 
            // infoDataGridViewTextBoxColumn
            // 
            this.infoDataGridViewTextBoxColumn.DataPropertyName = "info";
            this.infoDataGridViewTextBoxColumn.Frozen = true;
            this.infoDataGridViewTextBoxColumn.HeaderText = "info";
            this.infoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.infoDataGridViewTextBoxColumn.Name = "infoDataGridViewTextBoxColumn";
            this.infoDataGridViewTextBoxColumn.ReadOnly = true;
            this.infoDataGridViewTextBoxColumn.Width = 300;
            // 
            // bindingSource_Urls
            // 
            this.bindingSource_Urls.DataSource = typeof(crawlerWinForm.Urls);
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Location = new System.Drawing.Point(41, 83);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(37, 15);
            this.label_info.TabIndex = 1;
            this.label_info.Text = "信息";
            // 
            // btn_end
            // 
            this.btn_end.Location = new System.Drawing.Point(308, 373);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(133, 45);
            this.btn_end.TabIndex = 4;
            this.btn_end.Text = "结束爬行";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_URL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_urls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Urls)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_URL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource bindingSource_Urls;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.DataGridView dgv_urls;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn infoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_end;
    }
}

