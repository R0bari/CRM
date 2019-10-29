using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM.Tools
{
    class ListViewColumnComparer : IComparer
    {
        private int ColumnNumber;
        private SortOrder SortOrder;

        public ListViewColumnComparer(int column_number,
            SortOrder sort_order)
        {
            ColumnNumber = column_number;
            SortOrder = sort_order;
        }

        // Сравнение двух списков ListViewItems.
        public int Compare(object object_x, object object_y)
        {
            // Получить объекты как ListViewItems.
            ListViewItem item_x = object_x as ListViewItem;
            ListViewItem item_y = object_y as ListViewItem;

            // Получаем соответствующие значения подпозиции.
            string string_x;
            if (item_x.SubItems.Count <= ColumnNumber)
            {
                string_x = "";
            }
            else
            {
                string_x = item_x.SubItems[ColumnNumber].Text;
            }

            string string_y;
            if (item_y.SubItems.Count <= ColumnNumber)
            {
                string_y = "";
            }
            else
            {
                string_y = item_y.SubItems[ColumnNumber].Text;
            }

            int result;
            if (double.TryParse(string_x, out double double_x) &&
                double.TryParse(string_y, out double double_y))
            {
                // Обрабатываем как число.
                result = double_x.CompareTo(double_y);
            }
            else
            {
                if (DateTime.TryParse(string_x, out DateTime date_x) &&
                    DateTime.TryParse(string_y, out DateTime date_y))
                {
                    // Обработать как дату.
                    result = date_x.CompareTo(date_y);
                }
                else
                {
                    // Обработать как строку.
                    result = string_x.CompareTo(string_y);
                }
            }

            // Вернуть правильный результат в зависимости от того,
            // сортируем по возрастанию или по убыванию.
            if (SortOrder == SortOrder.Ascending)
            {
                return result;
            }
            else
            {
                return -result;
            }
        }
    }
}
