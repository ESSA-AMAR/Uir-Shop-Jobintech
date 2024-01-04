using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("ProductImages", Schema = "dbo")]
    public class ProductImages : BaseEntity
    {
        [Column("ImagePath")]
        public string? ImagePath { get; set; }

        [Column("ProductID")]
        public int IProductID { get; set; }


    }
}
