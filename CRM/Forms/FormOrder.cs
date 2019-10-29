using CRM.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class FormOrder : Form
    {
        private Order _order;
        public Order Order
        {
            get => _order;
            set
            {
                _order = value;
                OrderSum.Value = Convert.ToDecimal(_order.Sum);
                OrderClient.SelectedItem = _order.Client;
                if (_order.DateAndTime > OrderDateAndTime.MinDate)
                {
                    OrderDateAndTime.Value = _order.DateAndTime;
                }
                else
                {
                    OrderDateAndTime.Value = OrderDateAndTime.MinDate;
                }
                OrderStatus.SelectedItem = _order.Status;
            }
        }
        public FormOrder(List<Client> clientsList)
        {
            InitializeComponent();
            foreach (var client in clientsList)
            {
                OrderClient.Items.Add(client);
            }
        }

        private void ButtonAccept_Click(object sender, EventArgs e)
        {
            _order.Client = OrderClient.SelectedItem as Client;
            _order.Sum = Convert.ToDouble(OrderSum.Text);
            _order.DateAndTime = OrderDateAndTime.Value;
            _order.Status = OrderStatus.Text;
        }
    }
}
