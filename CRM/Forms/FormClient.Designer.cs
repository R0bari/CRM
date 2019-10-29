namespace CRM
{
    partial class FormClient
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
            this.addClientLabel = new System.Windows.Forms.Label();
            this.clientSurnameLabel = new System.Windows.Forms.Label();
            this.clientNameLabel = new System.Windows.Forms.Label();
            this.clientSurname = new System.Windows.Forms.TextBox();
            this.clientName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clientBirthDate = new System.Windows.Forms.DateTimePicker();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addClientLabel
            // 
            this.addClientLabel.AutoSize = true;
            this.addClientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addClientLabel.Location = new System.Drawing.Point(13, 13);
            this.addClientLabel.Name = "addClientLabel";
            this.addClientLabel.Size = new System.Drawing.Size(111, 25);
            this.addClientLabel.TabIndex = 0;
            this.addClientLabel.Text = "Add Client";
            // 
            // clientSurnameLabel
            // 
            this.clientSurnameLabel.AutoSize = true;
            this.clientSurnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientSurnameLabel.Location = new System.Drawing.Point(24, 68);
            this.clientSurnameLabel.Margin = new System.Windows.Forms.Padding(15, 30, 3, 0);
            this.clientSurnameLabel.Name = "clientSurnameLabel";
            this.clientSurnameLabel.Size = new System.Drawing.Size(74, 20);
            this.clientSurnameLabel.TabIndex = 1;
            this.clientSurnameLabel.Text = "Surname";
            // 
            // clientNameLabel
            // 
            this.clientNameLabel.AutoSize = true;
            this.clientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientNameLabel.Location = new System.Drawing.Point(24, 118);
            this.clientNameLabel.Margin = new System.Windows.Forms.Padding(15, 30, 3, 0);
            this.clientNameLabel.Name = "clientNameLabel";
            this.clientNameLabel.Size = new System.Drawing.Size(51, 20);
            this.clientNameLabel.TabIndex = 2;
            this.clientNameLabel.Text = "Name";
            // 
            // clientSurname
            // 
            this.clientSurname.Location = new System.Drawing.Point(131, 68);
            this.clientSurname.Margin = new System.Windows.Forms.Padding(30, 3, 3, 15);
            this.clientSurname.Name = "clientSurname";
            this.clientSurname.Size = new System.Drawing.Size(100, 20);
            this.clientSurname.TabIndex = 3;
            // 
            // clientName
            // 
            this.clientName.Location = new System.Drawing.Point(131, 118);
            this.clientName.Margin = new System.Windows.Forms.Padding(0);
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(100, 20);
            this.clientName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 168);
            this.label1.Margin = new System.Windows.Forms.Padding(15, 30, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Birth Date";
            // 
            // clientBirthDate
            // 
            this.clientBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.clientBirthDate.Location = new System.Drawing.Point(131, 168);
            this.clientBirthDate.Name = "clientBirthDate";
            this.clientBirthDate.Size = new System.Drawing.Size(100, 20);
            this.clientBirthDate.TabIndex = 5;
            this.clientBirthDate.Value = new System.DateTime(2019, 10, 26, 13, 18, 13, 0);
            // 
            // buttonAccept
            // 
            this.buttonAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAccept.Location = new System.Drawing.Point(151, 219);
            this.buttonAccept.Margin = new System.Windows.Forms.Padding(3, 3, 3, 25);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(80, 30);
            this.buttonAccept.TabIndex = 6;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.ButtonAccept_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(28, 219);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(80, 30);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 274);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.clientBirthDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientName);
            this.Controls.Add(this.clientSurname);
            this.Controls.Add(this.clientNameLabel);
            this.Controls.Add(this.clientSurnameLabel);
            this.Controls.Add(this.addClientLabel);
            this.Name = "FormClient";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.Text = "Adding Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addClientLabel;
        private System.Windows.Forms.Label clientSurnameLabel;
        private System.Windows.Forms.Label clientNameLabel;
        private System.Windows.Forms.TextBox clientSurname;
        private System.Windows.Forms.TextBox clientName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker clientBirthDate;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonCancel;
    }
}