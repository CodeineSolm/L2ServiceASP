using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPCoreL2Services.Domain.Entities
{
    public class EntityBase
    {
        [Required]
        public int Id { get; set; }

        [Display(Name = "Название")]
        public string Title { get; set; }

        [Display(Name = "Краткое описание")]
        public string Subtitle { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Display(Name = "Главное изображение")]
        public string Preview { get; set; }

        [Display(Name = "Остальные изображения")]
        public string Subpreview { get; set; }

        [Display(Name = "Цена услуги")]
        public decimal Price { get; set; }

        [Display(Name = "SEO метатег Title")]
        public string MetaTitle { get; set; }

        [Display(Name = "SEO метатег Discription")]
        public string MetaDiscription { get; set; }

        [Display(Name = "SEO метатег Keywords")]
        public string MetaKeywords { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }
    }
}
