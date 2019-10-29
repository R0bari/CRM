using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DataModels
{
    public class Order : IValidate
    {
        /// <summary>
        /// Id заказа
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Сумма заказа
        /// </summary>
        public double Sum { get; set; }
        /// <summary>
        /// Дата и время заказа
        /// </summary>
        public DateTime DateAndTime { get; set; }
        /// <summary>
        /// Состояние заказа
        /// </summary>
        public string Status { get; set; }
       
        /// <summary>
        /// Проверка на корректность
        /// </summary>
        public bool IsValid
        {
            get
            {
                if (Sum == 0) return false;
                if (string.IsNullOrWhiteSpace(Status)) return false;
                return true;
            }
        }
        /// <summary>
        /// Клиент, сделавший заказ
        /// </summary>
        public int ClientId { get; set; }   //  Внешний ключ
        [NotMapped]
        public Client Client { get; set; }  //  Навигационное свойство
        public void Set(Order order)
        {
            Sum = order.Sum;
            DateAndTime = order.DateAndTime;
            Status = order.Status;
            ClientId = order.Client.Id;
            Client = order.Client;
        }
    }
}
