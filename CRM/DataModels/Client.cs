using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DataModels
{
    public class Client : IValidate
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
        public bool IsValid
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Surname)) return false;
                if (string.IsNullOrWhiteSpace(Name)) return false;
                return true;
            }
        }
        /// <summary>
        /// Стандартный конструктор без параметров
        /// </summary>
        public Client() => BirthDate = DateTime.Now;
        /// <summary>
        /// Задать клиенту значение другого клиента
        /// </summary>
        /// <param name="client"></param>
        public void Set(Client client) => (Surname, Name, BirthDate) = (client.Surname, client.Name, client.BirthDate);
        /// <summary>
        /// Перегрузка метода ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString() => Surname + " " + Name[0] + ". " + BirthDate.ToShortDateString();
    }
}
