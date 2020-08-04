using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCoreL2Services.Models
{
    public class Orders
    {
        [Required]    
        public int Id { get; set; }

        [Display(Name = "Имя пользователя")]
        public string Nickname { get; set; }

        [Display(Name = "Сервер")]
        public string Server { get; set; }

        [Display(Name = "Услуга")]
        public string Service { get; set; }

        [Display(Name = "Статус заказа")]
        public string Status { get; set; }
        
        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }
    }
}
