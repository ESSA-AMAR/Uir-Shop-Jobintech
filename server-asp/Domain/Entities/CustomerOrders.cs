using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("CustomerOrders", Schema = "dbo")]

    public class CustomerOrders : BaseEntity
    {
        [Column("ClientID")]
        public int ClientID { get; set; }

        [Column("productId")]
        public int productId { get; set; }

        [Column("qtyOrded")]
        public int qtyOrded { get; set; }

        [Column("OrderDate")]
        public DateTime OrderDate { get; set; }

        [Column("TotalPrice")]
        public decimal TotalPrice { get; set; }
    }
}
