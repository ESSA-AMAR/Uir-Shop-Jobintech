using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class BaseEntity
    {
        [Column("Id")]
        public int Id { get; set; }
    }
}
