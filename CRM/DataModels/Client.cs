using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DataModels
{
    public class Client
    {
        /// <summary>
        /// Id клиента
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Фамилия клиента
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Имя клиента
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Дата рождения клиента
        /// </summary>
        public DateTime BirthDate { get; set; }
        /// <summary>
        /// Стандартный конструктор без параметров
        /// </summary>
        public Client()
        {
            BirthDate = DateTime.Now;
        }
        /// <summary>
        /// Задать клиенту значение другого клиента
        /// </summary>
        /// <param name="client"></param>
        public void Set(Client client)
        {
            Surname = client.Surname;
            Name = client.Name;
            BirthDate = client.BirthDate;
        }
        /// <summary>
        /// Перегрузка метода ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Surname + " " + Name[0] + ". " + BirthDate.ToShortDateString();
        }
    }
}
