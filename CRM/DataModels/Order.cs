using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DataModels
{
    public class Order
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
        public int ClientId { get; set; }   //  Внешний ключ
        /// <summary>
        /// Клиент, сделавший заказ
        /// </summary>
        [NotMapped]
        public Client Client { get; set; }  //  Навигационное свойство
    }
}
