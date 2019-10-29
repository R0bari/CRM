using CRM.DataModels;
using CRM.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CRM
{
    public partial class FormMain : Form
    {
        public static List<Client> ClientsList = new List<Client>();
        public static List<Order> OrdersList = new List<Order>();

        readonly FormClient _formClient;
        readonly FormOrder _formOrder;

        EventHandler ClientAdded;
        EventHandler ClientEdited;
        EventHandler ClientRemoved;
        EventHandler OrderAdded;
        EventHandler OrderEdited;
        EventHandler OrderRemoved;

        public FormMain()
        {
            InitializeComponent();
            ClientAdded += List_ClientAdded;
            ClientEdited += List_ClientEdited;
            ClientRemoved += List_ClientRemoved;
            OrderAdded += List_OrderAdded;
            OrderEdited += List_OrderEdited;
            OrderRemoved += List_OrderRemoved;

            try
            {
                Connect();
            }
            catch
            {
                MessageBox.Show("Connection failed.");
            }

            UpdateLists();

            _formClient = new FormClient();
            _formOrder = new FormOrder(ClientsList);
        }
        private void AddClient_Click(object sender, EventArgs e)
        {
            var client = new Client();
            _formClient.Client = client;
            if (_formClient.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var dataBase = new CRMContext())
                    {
                        dataBase.Clients.Add(_formClient.Client);
                        dataBase.SaveChanges();
                        ClientAdded?.Invoke(_formClient.Client, EventArgs.Empty);
                        tabControl1.SelectTab(tabClient);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
        private void EditClient_Click(object sender, EventArgs e)
        {
            try
            {
                var client = (clientListView.SelectedItems[0].Tag as Client);
                _formClient.Client = client;
                if (_formClient.ShowDialog() == DialogResult.OK)
                {

                    using (var dataBase = new CRMContext())
                    {
                        Client tempClient = dataBase.Clients.Find(client.Id);
                        tempClient.Surname = client.Surname;
                        tempClient.Name = client.Name;
                        tempClient.BirthDate = client.BirthDate;
                        dataBase.SaveChanges();
                        ClientEdited?.Invoke(_formClient.Client, EventArgs.Empty);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Клиент не выбран.");
            }
        }
        private void RemoveClient_Click(object sender, EventArgs e)
        {
            try
            {
                if (clientListView.SelectedItems[0].Tag is Client client)
                {
                    ClientRemoved?.Invoke(client, EventArgs.Empty);
                }
            }
            catch
            {
                MessageBox.Show("Клиент не выбран.");
            }
        }
        private void AddOrder_Click(object sender, EventArgs e)
        {
            var order = new Order();
            _formOrder.Order = order;
            if (_formOrder.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    order.ClientId = order.Client.Id;
                    using (var dataBase = new CRMContext())
                    {
                        dataBase.Orders.Add(order);
                        dataBase.SaveChanges();
                        OrderAdded?.Invoke(order, EventArgs.Empty);
                        tabControl1.SelectTab(tabOrder);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
        private void EditOrder_Click(object sender, EventArgs e)
        {
            try
            {
                var order = (orderListView.SelectedItems[0].Tag as Order);
                _formOrder.Order = order;
                if (_formOrder.ShowDialog() == DialogResult.OK)
                {
                    using (var dataBase = new CRMContext())
                    {
                        Order tempOrder = dataBase.Orders.Find(order.Id);
                        tempOrder.Sum = order.Sum;
                        tempOrder.Client = order.Client;
                        tempOrder.DateAndTime = order.DateAndTime;
                        tempOrder.Status = order.Status;
                        dataBase.SaveChanges();
                        OrderEdited?.Invoke(_formOrder.Order, EventArgs.Empty);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Заказ не выбран.");
            }
        }
        private void RemoveOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (orderListView.SelectedItems[0].Tag is Order order)
                {
                    OrderRemoved?.Invoke(order.Id, EventArgs.Empty);
                }
            }
            catch
            {
                MessageBox.Show("Заказ не выбран.");
                //Connect();
                //UpdateLists();
            }
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Добавление клиента в таблицу
        /// </summary>
        /// <param name="client"></param>
        private void AddToListView(Client client)
        {
            var listItem = new ListViewItem
            {
                Tag = client,
                Text = client.Surname
            };
            listItem.SubItems.Add(client.Name);
            listItem.SubItems.Add(client.BirthDate.ToString("yyyy.MM.dd"));

            clientListView.Items.Add(listItem);
        }
        /// <summary>
        /// Добавление заказа в таблицу
        /// </summary>
        /// <param name="order"></param>
        private void AddToListView(Order order)
        {
            foreach (var client in ClientsList)
            {
                if (client.Id == order.ClientId)
                {
                    order.Client = client;
                    break;
                }
            }

            var listItem = new ListViewItem
            {
                Tag = order,
                Text = order.Client.Surname + " " + order.Client.Name
            };
            listItem.SubItems.Add(order.Sum.ToString());
            listItem.SubItems.Add(order.DateAndTime.ToString("yyyy.MM.dd  hh:mm"));
            listItem.SubItems.Add(order.Status);

            orderListView.Items.Add(listItem);
        }
        /// <summary>
        /// Удаление клиента из таблицы
        /// </summary>
        /// <param name="client"></param>
        private void DeleteFromListView(Client client)
        {
            for (int i = 0; i < clientListView.Items.Count; ++i)
            {
                if (((Client)(clientListView.Items[i].Tag)).Id == client.Id)
                {
                    clientListView.Items.RemoveAt(i);
                    break;
                }
            }
        }
        /// <summary>
        /// Удаление заказа из таблицы
        /// </summary>
        /// <param name="order"></param>
        private void DeleteFromListView(Order order)
        {
            for (int i = 0; i < orderListView.Items.Count; ++i)
            {
                if (((Order)(orderListView.Items[i].Tag)).Id == order.Id)
                {
                    orderListView.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void List_ClientAdded(object sender, EventArgs e)
        {
            if (sender is Client client)
            {
                AddToListView(client);
                _formOrder.OrderClient.Items.Add(client);
            }
        }
        private void List_ClientEdited(object sender, EventArgs e)
        {
            if (sender is Client client)
            {
                foreach (Client item in ClientsList)
                {
                    if (item.Id == client.Id)
                    {
                        item.Surname = client.Surname;
                        item.Name = client.Name;
                        item.BirthDate = client.BirthDate;
                    }
                }
                UpdateLists();

                foreach (Client item in _formOrder.OrderClient.Items)
                {
                    if (client.Id == item.Id)
                    {
                        item.Surname = client.Surname;
                        item.Name = client.Name;
                        item.BirthDate = client.BirthDate;
                    }
                }
            }
        }
        private void List_ClientRemoved(object sender, EventArgs e)
        {
            if (sender is Client client)
            {
                DeleteClient(client);
                DeleteFromListView(client);
                ClientsList.Remove(client);

                foreach (var order in OrdersList)
                {
                    if (order.Client.Id == client.Id)
                    {
                        DeleteOrder(order);
                        DeleteFromListView(order);
                        OrdersList.Remove(order);
                        break;
                    }
                }
                foreach (var item in _formOrder.OrderClient.Items)
                {
                    if ((item as Client).Id == client.Id)
                    {
                        _formOrder.OrderClient.Items.Remove(item);
                        break;
                    }
                }
            }
        }
        private void List_OrderAdded(object sender, EventArgs e)
        {
            OrdersList.Add(sender as Order);
            if (sender is Order order)
            {
                AddToListView(order);
            }
        }
        private void List_OrderEdited(object sender, EventArgs e)
        {
            if (sender is Order order)
            {
                foreach (var item in OrdersList)
                {
                    if (item.Id == order.Id)
                    {
                        item.Sum = order.Sum;
                        item.Client = order.Client;
                        item.DateAndTime = order.DateAndTime;
                        item.Status = order.Status;
                    }
                    break;
                }
                UpdateOrderList();
            }
        }
        private void List_OrderRemoved(object sender, EventArgs e)
        {
            var orderId = (int)sender;
            foreach (var order in OrdersList)
            {
                if (order.Id == orderId)
                {
                    DeleteOrder(order);
                    DeleteFromListView(order);
                    OrdersList.Remove(order);
                    break;
                }
            }
        }

        /// <summary>
        /// Удаление клиента из базы
        /// </summary>
        /// <param name="client"></param>
        private void DeleteClient(Client client)
        {
            using (var dataBase = new CRMContext())
            {
                Client tempClient = dataBase.Clients
                    .Where(o => o.Id == client.Id)
                    .FirstOrDefault();
                if (tempClient != null)
                {
                    dataBase.Clients.Remove(tempClient);
                    dataBase.SaveChanges();
                }
            }
        }
        /// <summary>
        /// Удаление заказа из базы
        /// </summary>
        /// <param name="order"></param>
        private void DeleteOrder(Order order)
        {
            using (var dataBase = new CRMContext())
            {
                Order tempOrder = dataBase.Orders
                    .Where(o => o.Id == order.Id)
                    .FirstOrDefault();

                if (tempOrder != null)
                {
                    dataBase.Orders.Remove(tempOrder);
                    dataBase.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Начальное заполнение списков данными из базы
        /// </summary>
        private void Connect()
        {
            ClientsList.Clear();
            OrdersList.Clear();

            using (var dataBase = new CRMContext())
            {
                var Clients = dataBase.Clients;
                var Orders = dataBase.Orders;
                foreach (Client client in Clients)
                {
                    ClientsList.Add(client);
                }
                foreach (Order order in Orders)
                {
                    OrdersList.Add(order);
                }
            }
        }
        /// <summary>
        /// Начальное заполнение таблиц данными из базы
        /// </summary>
        private void UpdateLists()
        {
            UpdateClientList();
            UpdateOrderList();
        }
        private void UpdateClientList()
        {
            clientListView.Items.Clear();
            foreach (var client in ClientsList)
            {
                AddToListView(client);
            }
        }
        private void UpdateOrderList()
        {
            orderListView.Items.Clear();
            foreach (var order in OrdersList)
            {
                AddToListView(order);
            }
        }
        private void Refresh_Click(object sender, EventArgs e)
        {
            Connect();
            UpdateLists();
        }

        /// <summary>
        /// Сортировка таблицы клиентов по столбцам
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Client_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            clientListView.ListViewItemSorter = new ListViewColumnComparer(e.Column);
        }
        /// <summary>
        /// Сортировка таблицы заказов по столбцам
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Order_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            //Сортирует типы string, поэтому некорректно работает при сортировке по Sum
            //orderListView.ListViewItemSorter = new ListViewColumnComparer(e.Column);
        }
        /// <summary>
        /// Сортировка таблицы запроса по столбцам
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Query_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            //Сортирует типы string, поэтому некорректно работает при сортировке по Sum
            //queryListView.ListViewItemSorter = new ListViewColumnComparer(e.Column);
        }
        /// <summary>
        /// Получить сумму заказов со статусом выполнен по каждому клиенту, произведенных в день рождения клиента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BirthdayQuery_Click(object sender, EventArgs e)
        {
            double tempSum = default(double);

            queryListView.Clear();
            queryListView.Columns.Add("Client");
            queryListView.Columns.Add("Birth Date");
            queryListView.Columns.Add("Sum");

            queryListView.Columns[0].Width = 160;
            queryListView.Columns[1].Width = 100;
            queryListView.Columns[2].Width = 100;

            foreach (var client in ClientsList)
            {
                tempSum = CalculateClientTotal(client);

                var listItem = new ListViewItem
                {
                    Tag = client,
                    Text = client.Surname + " " + client.Name
                };
                listItem.SubItems.Add(client.BirthDate.ToString("yyyy.MM.dd"));
                listItem.SubItems.Add(tempSum.ToString());

                if (tempSum > 0)
                {
                    queryListView.Items.Add(listItem);
                }
            }

            tabControl1.SelectTab(tabQuery);
        }
        /// <summary>
        /// Считает общую сумму стоимостей выполненных заказов клиента в его день рождения.
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        private double CalculateClientTotal(Client client)
        {
            double sum = 0;
            
            foreach (var order in OrdersList)
            {
                if (client.Id == order.ClientId &&
                    client.BirthDate.Day == order.DateAndTime.Day &&
                    client.BirthDate.Month == order.DateAndTime.Month &&
                    order.Status == "Выполнено")
                {
                    sum += Convert.ToDouble(order.Sum);
                }
            }
            return sum;
        }
        /// <summary>
        /// Получить список часов от 00.00 до 24.00 в порядке убывания со средним чеком за каждый час 
        /// (Средний чек=Сумма заказов/Кол-во заказов) по всем заказам со статусом Выполнен
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HourQuery_Click(object sender, EventArgs e)
        {
            queryListView.Clear();
            queryListView.Sorting = SortOrder.Descending;
            queryListView.Columns.Add("Hour");
            queryListView.Columns.Add("Order Quantity");
            queryListView.Columns.Add("Total");
            queryListView.Columns.Add("Average");

            queryListView.Columns[0].Width = 100;
            queryListView.Columns[1].Width = 160;
            queryListView.Columns[2].Width = 100;
            queryListView.Columns[3].Width = 100;
            
            CalculateOrdersHourly();

            tabControl1.SelectTab(tabQuery);
        }
        private void CalculateOrdersHourly()
        {
            for (int currentHour = 0; currentHour < 24; ++currentHour)
            {
                double tempSum = default(double);
                int orderCounter = default(int);
                double average = default(double);

                var listItem = new ListViewItem
                {
                    Text = currentHour.ToString()
                };

                foreach (var order in OrdersList)
                {
                    if (order.DateAndTime.Hour == currentHour &&
                        order.Status == "Выполнено")
                    {
                        tempSum += order.Sum;
                        ++orderCounter;
                    }
                }
                listItem.SubItems.Add(orderCounter.ToString());
                listItem.SubItems.Add(tempSum.ToString());

                average = tempSum / orderCounter;
                listItem.SubItems.Add(average.ToString());

                if (tempSum > 0)
                {
                    queryListView.Items.Add(listItem);
                }
            }
        }
        /// <summary>
        /// Очистка таблицы запроса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clear_Click(object sender, EventArgs e)
        {
            queryListView.Clear();
        }
    }
}
