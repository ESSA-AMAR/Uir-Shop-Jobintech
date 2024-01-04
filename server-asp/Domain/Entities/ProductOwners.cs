using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{

    [Table("ProductOwners", Schema = "dbo")]

    public class ProductOwners : BaseEntity    {
        [Column("UserId")]
        public int UserId { get; set; }

    }
}
