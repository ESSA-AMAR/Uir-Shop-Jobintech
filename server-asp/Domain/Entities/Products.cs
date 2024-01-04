using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("Products", Schema = "dbo")]
    public class Product : BaseEntity
    {
        [Column("ProductTitle")]
        public string? ProductTitle { get; set; }

        [Column("SubProductTitle")]
        public string? SubProductTitle { get; set; }

        [Column("ProductDescription")]
        public string? ProductDescription { get; set; }

        [Column("Price")]
        public decimal Price { get; set; }

        [Column("CategoryID")]
        public int CategoryID { get; set; }

        [Column("productOwner")]
        public int? ProductOwner { get; set; }

        [Column("qtyProduct")]
        public int QtyProduct { get; set; }

        // Navigation properties
        //[ForeignKey("CategoryID")]
        //public Category Category { get; set; }

        //[ForeignKey("ProductOwner")]
        //public ProductOwner Owner { get; set; }
    }

}
