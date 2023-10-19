using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSolutions.Entity
{
    [Table("Product")] // Sản phẩm
    public class Product
    {
        public int Id { set; get; }
        public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public int ViewCount { set; get; }
        public DateTime DateCreated { set; get; }

        [Required]
        public string SeoAlias { get; set; }
        [ForeignKey("ProductId")]
        public ICollection<ProductInCategory> ProductInCategories { get; set; }
        [ForeignKey("ProductId")]
        public ICollection<OrderDetail> OrderDetails { get; set; }

        [ForeignKey("ProductId")]
        public ICollection<Cart> Carts { get; set; }
        [ForeignKey("ProductId")]
        public ICollection<ProductTranslation> ProductTranslations { get; set; }
    }
}
