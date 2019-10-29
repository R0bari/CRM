namespace CRM
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.birthdayOrdersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HourOrdersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabClient = new System.Windows.Forms.TabPage();
            this.clientListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabOrder = new System.Windows.Forms.TabPage();
            this.orderListView = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabQuery = new System.Windows.Forms.TabPage();
            this.queryListView = new System.Windows.Forms.ListView();
            this.menuStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabClient.SuspendLayout();
            this.tabOrder.SuspendLayout();
            this.tabQuery.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.ManageToolStripMenuItem,
            this.queriesToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(587, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.ToolTipText = "Update data";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.ToolTipText = "Exit the program";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ManageToolStripMenuItem
            // 
            this.ManageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClientsToolStripMenuItem,
            this.OrdersToolStripMenuItem});
            this.ManageToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManageToolStripMenuItem.Name = "ManageToolStripMenuItem";
            this.ManageToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.ManageToolStripMenuItem.Text = "Manage";
            // 
            // ClientsToolStripMenuItem
            // 
            this.ClientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddClientToolStripMenuItem,
            this.EditClientToolStripMenuItem,
            this.RemoveClientToolStripMenuItem});
            this.ClientsToolStripMenuItem.Name = "ClientsToolStripMenuItem";
            this.ClientsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ClientsToolStripMenuItem.Text = "Clients";
            // 
            // AddClientToolStripMenuItem
            // 
            this.AddClientToolStripMenuItem.Name = "AddClientToolStripMenuItem";
            this.AddClientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AddClientToolStripMenuItem.Text = "Add";
            this.AddClientToolStripMenuItem.ToolTipText = "Add new client";
            this.AddClientToolStripMenuItem.Click += new System.EventHandler(this.AddClient_Click);
            // 
            // EditClientToolStripMenuItem
            // 
            this.EditClientToolStripMenuItem.Name = "EditClientToolStripMenuItem";
            this.EditClientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.EditClientToolStripMenuItem.Text = "Edit";
            this.EditClientToolStripMenuItem.ToolTipText = "Edit chosen client";
            this.EditClientToolStripMenuItem.Click += new System.EventHandler(this.EditClient_Click);
            // 
            // RemoveClientToolStripMenuItem
            // 
            this.RemoveClientToolStripMenuItem.Name = "RemoveClientToolStripMenuItem";
            this.RemoveClientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.RemoveClientToolStripMenuItem.Text = "Remove";
            this.RemoveClientToolStripMenuItem.ToolTipText = "Remove chosen client\r\nand all his(her) orders";
            this.RemoveClientToolStripMenuItem.Click += new System.EventHandler(this.RemoveClient_Click);
            // 
            // OrdersToolStripMenuItem
            // 
            this.OrdersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddOrderToolStripMenuItem,
            this.EditOrderToolStripMenuItem,
            this.RemoveOrderToolStripMenuItem});
            this.OrdersToolStripMenuItem.Name = "OrdersToolStripMenuItem";
            this.OrdersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OrdersToolStripMenuItem.Text = "Orders";
            // 
            // AddOrderToolStripMenuItem
            // 
            this.AddOrderToolStripMenuItem.Name = "AddOrderToolStripMenuItem";
            this.AddOrderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AddOrderToolStripMenuItem.Text = "Add";
            this.AddOrderToolStripMenuItem.ToolTipText = "Add new order";
            this.AddOrderToolStripMenuItem.Click += new System.EventHandler(this.AddOrder_Click);
            // 
            // EditOrderToolStripMenuItem
            // 
            this.EditOrderToolStripMenuItem.Name = "EditOrderToolStripMenuItem";
            this.EditOrderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.EditOrderToolStripMenuItem.Text = "Edit";
            this.EditOrderToolStripMenuItem.ToolTipText = "Edit chosen order";
            this.EditOrderToolStripMenuItem.Click += new System.EventHandler(this.EditOrder_Click);
            // 
            // RemoveOrderToolStripMenuItem
            // 
            this.RemoveOrderToolStripMenuItem.Name = "RemoveOrderToolStripMenuItem";
            this.RemoveOrderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.RemoveOrderToolStripMenuItem.Text = "Remove";
            this.RemoveOrderToolStripMenuItem.ToolTipText = "Remove chosen order";
            this.RemoveOrderToolStripMenuItem.Click += new System.EventHandler(this.RemoveOrder_Click);
            // 
            // queriesToolStripMenuItem
            // 
            this.queriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.birthdayOrdersMenuItem,
            this.HourOrdersMenuItem,
            this.clearToolStripMenuItem});
            this.queriesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.queriesToolStripMenuItem.Name = "queriesToolStripMenuItem";
            this.queriesToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.queriesToolStripMenuItem.Text = "Queries";
            // 
            // birthdayOrdersMenuItem
            // 
            this.birthdayOrdersMenuItem.Name = "birthdayOrdersMenuItem";
            this.birthdayOrdersMenuItem.Size = new System.Drawing.Size(180, 22);
            this.birthdayOrdersMenuItem.Text = "Birthday Orders";
            this.birthdayOrdersMenuItem.ToolTipText = "Get the amount of orders with the \r\nstatus completed for each client,\r\nmade on th" +
    "e client’s birthday";
            this.birthdayOrdersMenuItem.Click += new System.EventHandler(this.BirthdayQuery_Click);
            // 
            // HourOrdersMenuItem
            // 
            this.HourOrdersMenuItem.Name = "HourOrdersMenuItem";
            this.HourOrdersMenuItem.Size = new System.Drawing.Size(180, 22);
            this.HourOrdersMenuItem.Text = "Hours";
            this.HourOrdersMenuItem.ToolTipText = "Get a list of hours from 00.00 to 24.00 \r\nwith an average check for each hour";
            this.HourOrdersMenuItem.Click += new System.EventHandler(this.HourQuery_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.ToolTipText = "Clear the query table";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.Clear_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabClient);
            this.tabControl1.Controls.Add(this.tabOrder);
            this.tabControl1.Controls.Add(this.tabQuery);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(563, 234);
            this.tabControl1.TabIndex = 1;
            // 
            // tabClient
            // 
            this.tabClient.Controls.Add(this.clientListView);
            this.tabClient.Location = new System.Drawing.Point(4, 29);
            this.tabClient.Name = "tabClient";
            this.tabClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabClient.Size = new System.Drawing.Size(555, 201);
            this.tabClient.TabIndex = 0;
            this.tabClient.Text = "Clients";
            this.tabClient.UseVisualStyleBackColor = true;
            // 
            // clientListView
            // 
            this.clientListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientListView.BackColor = System.Drawing.SystemColors.Window;
            this.clientListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.clientListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientListView.FullRowSelect = true;
            this.clientListView.Location = new System.Drawing.Point(-4, 0);
            this.clientListView.Name = "clientListView";
            this.clientListView.Size = new System.Drawing.Size(563, 205);
            this.clientListView.TabIndex = 0;
            this.clientListView.UseCompatibleStateImageBehavior = false;
            this.clientListView.View = System.Windows.Forms.View.Details;
            this.clientListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.Client_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Surname";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Birth Date";
            this.columnHeader3.Width = 100;
            // 
            // tabOrder
            // 
            this.tabOrder.Controls.Add(this.orderListView);
            this.tabOrder.Location = new System.Drawing.Point(4, 29);
            this.tabOrder.Name = "tabOrder";
            this.tabOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrder.Size = new System.Drawing.Size(555, 201);
            this.tabOrder.TabIndex = 1;
            this.tabOrder.Text = "Orders";
            this.tabOrder.UseVisualStyleBackColor = true;
            // 
            // orderListView
            // 
            this.orderListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.orderListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderListView.FullRowSelect = true;
            this.orderListView.Location = new System.Drawing.Point(-4, 0);
            this.orderListView.Name = "orderListView";
            this.orderListView.Size = new System.Drawing.Size(563, 205);
            this.orderListView.TabIndex = 0;
            this.orderListView.UseCompatibleStateImageBehavior = false;
            this.orderListView.View = System.Windows.Forms.View.Details;
            this.orderListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.Order_ColumnClick);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Client";
            this.columnHeader4.Width = 160;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Sum";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Date and Time";
            this.columnHeader6.Width = 160;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Status";
            this.columnHeader7.Width = 120;
            // 
            // tabQuery
            // 
            this.tabQuery.Controls.Add(this.queryListView);
            this.tabQuery.Location = new System.Drawing.Point(4, 29);
            this.tabQuery.Name = "tabQuery";
            this.tabQuery.Size = new System.Drawing.Size(555, 201);
            this.tabQuery.TabIndex = 2;
            this.tabQuery.Text = "Query Result";
            this.tabQuery.UseVisualStyleBackColor = true;
            // 
            // queryListView
            // 
            this.queryListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryListView.Location = new System.Drawing.Point(-4, 0);
            this.queryListView.Name = "queryListView";
            this.queryListView.Size = new System.Drawing.Size(563, 205);
            this.queryListView.TabIndex = 0;
            this.queryListView.UseCompatibleStateImageBehavior = false;
            this.queryListView.View = System.Windows.Forms.View.Details;
            this.queryListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.Query_ColumnClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(587, 273);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.Text = "Order Manager";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabClient.ResumeLayout(false);
            this.tabOrder.ResumeLayout(false);
            this.tabQuery.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem birthdayOrdersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HourOrdersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabClient;
        private System.Windows.Forms.TabPage tabOrder;
        private System.Windows.Forms.TabPage tabQuery;
        private System.Windows.Forms.ListView clientListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView orderListView;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ListView queryListView;
    }
}

