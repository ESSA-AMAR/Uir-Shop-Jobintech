using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("Categories", Schema = "dbo")]

    public class Categories : BaseEntity
    {
        [Column("CategoryName")]
        public string? CategoryName { get; set; }
    }
}
