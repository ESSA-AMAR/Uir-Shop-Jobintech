using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("Users", Schema = "dbo")]

    public class Users : BaseEntity
    {

        [Column("FirstName")]
        public string? FirstName { get; set; }

        [Column("LastName")]
        public string? LastName { get; set; }

        [Column("Email")]
        public string? Email { get; set; }

        [Column("PhoneNumber")]
        public string? PhoneNumber { get; set; }

        [Column("Description")]
        public string? Description { get; set; }

        [Column("ProfileImage")]
        public string? ProfileImage { get; set; }

        [Column("address")]
        public string? address { get; set; }
    }
}
