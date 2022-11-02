using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheiApp.Models
{
    /// <summary>
    /// Описывает глобальные свойства приложения
    /// </summary>
    public static class  Global
    {
        /// <summary>
        /// Авторизованный пользователь
        /// </summary>
        public static Polzovatel Polzovatel { get; set; }
        /// <summary>
        /// Выбранное изделие при добавлении в заказ
        /// </summary>
        public static Izdelie Izdel { get; set; }
    }
}
