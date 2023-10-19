using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSolutions.Entity
{
    [Table("Language")] // Ngôn ngữ
    public class Language
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsDefault { get; set; }

        [ForeignKey("ProductId")]
        public ICollection<ProductTranslation> ProductTranslations { get; set; }

        [ForeignKey("LanguageId")]
        public ICollection<CategoryTranslation> CategoryTranslations { get; set; }
    }
}
