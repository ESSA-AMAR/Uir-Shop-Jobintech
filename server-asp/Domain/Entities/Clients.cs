using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{

    [Table("Clients", Schema = "dbo")]
    public class Clients : BaseEntity
    {

        [Column("UserId")]
        public int UserId { get; set; }
    }
}
