namespace CRM
{
    partial class FormOrder
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
            this.OrderLabel = new System.Windows.Forms.Label();
            this.orderSumLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OrderSum = new System.Windows.Forms.TextBox();
            this.OrderClient = new System.Windows.Forms.ComboBox();
            this.OrderDateAndTime = new System.Windows.Forms.DateTimePicker();
            this.OrderStatus = new System.Windows.Forms.ComboBox();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addOrderLabel
            // 
            this.OrderLabel.AutoSize = true;
            this.OrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderLabel.Location = new System.Drawing.Point(13, 13);
            this.OrderLabel.Name = "addOrderLabel";
            this.OrderLabel.Size = new System.Drawing.Size(110, 25);
            this.OrderLabel.TabIndex = 0;
            this.OrderLabel.Text = "Add Order";
            // 
            // orderSumLabel
            // 
            this.orderSumLabel.AutoSize = true;
            this.orderSumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderSumLabel.Location = new System.Drawing.Point(24, 68);
            this.orderSumLabel.Margin = new System.Windows.Forms.Padding(15, 30, 3, 0);
            this.orderSumLabel.Name = "orderSumLabel";
            this.orderSumLabel.Size = new System.Drawing.Size(42, 20);
            this.orderSumLabel.TabIndex = 1;
            this.orderSumLabel.Text = "Sum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(15, 30, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(15, 30, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date and time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(24, 218);
            this.label3.Margin = new System.Windows.Forms.Padding(15, 30, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status";
            // 
            // OrderSum
            // 
            this.OrderSum.Location = new System.Drawing.Point(139, 68);
            this.OrderSum.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.OrderSum.Name = "OrderSum";
            this.OrderSum.Size = new System.Drawing.Size(117, 20);
            this.OrderSum.TabIndex = 5;
            // 
            // OrderClient
            // 
            this.OrderClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OrderClient.FormattingEnabled = true;
            this.OrderClient.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.OrderClient.Location = new System.Drawing.Point(139, 117);
            this.OrderClient.Name = "OrderClient";
            this.OrderClient.Size = new System.Drawing.Size(117, 21);
            this.OrderClient.TabIndex = 6;
            // 
            // OrderDateAndTime
            // 
            this.OrderDateAndTime.CustomFormat = "dd.MM.yy  HH.mm";
            this.OrderDateAndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.OrderDateAndTime.Location = new System.Drawing.Point(139, 167);
            this.OrderDateAndTime.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.OrderDateAndTime.Name = "OrderDateAndTime";
            this.OrderDateAndTime.Size = new System.Drawing.Size(117, 20);
            this.OrderDateAndTime.TabIndex = 7;
            // 
            // OrderStatus
            // 
            this.OrderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OrderStatus.FormattingEnabled = true;
            this.OrderStatus.Items.AddRange(new object[] {
            "Не определено",
            "Отменено",
            "Выполнено"});
            this.OrderStatus.Location = new System.Drawing.Point(139, 217);
            this.OrderStatus.Name = "OrderStatus";
            this.OrderStatus.Size = new System.Drawing.Size(117, 21);
            this.OrderStatus.TabIndex = 8;
            // 
            // buttonAccept
            // 
            this.buttonAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAccept.Location = new System.Drawing.Point(176, 263);
            this.buttonAccept.Margin = new System.Windows.Forms.Padding(3, 3, 3, 25);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(80, 30);
            this.buttonAccept.TabIndex = 9;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.ButtonAccept_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(28, 263);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 25);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(80, 30);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 327);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.OrderStatus);
            this.Controls.Add(this.OrderDateAndTime);
            this.Controls.Add(this.OrderClient);
            this.Controls.Add(this.OrderSum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderSumLabel);
            this.Controls.Add(this.OrderLabel);
            this.Name = "FormOrder";
            this.Text = "Adding Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label OrderLabel;
        private System.Windows.Forms.Label orderSumLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OrderSum;
        public System.Windows.Forms.ComboBox OrderClient;
        private System.Windows.Forms.DateTimePicker OrderDateAndTime;
        private System.Windows.Forms.ComboBox OrderStatus;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonCancel;
    }
}