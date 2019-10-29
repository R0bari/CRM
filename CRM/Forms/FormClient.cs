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
    public partial class FormClient : Form
    {
        private Client _client;
        public Client Client
        {
            get => _client;
            set
            {
                _client = value;
                clientSurname.Text = _client.Surname;
                clientName.Text = _client.Name;
                clientBirthDate.Value = _client.BirthDate;
            }
        }
        public FormClient()
        {
            InitializeComponent();
        }
        private void ButtonAccept_Click(object sender, EventArgs e)
        {
            _client.Surname = clientSurname.Text;
            _client.Name = clientName.Text;
            _client.BirthDate = clientBirthDate.Value;
        }
    }
}
