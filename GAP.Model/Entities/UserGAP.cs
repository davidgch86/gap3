using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GAP.Model
{
    [Table("UsersGAP")]
    public class UsersGAP
    {
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar", Order = 2)]
        [MaxLength(150)]
        public string UserName { get; set; }

        [Column(TypeName = "nvarchar", Order = 3)]
        [MaxLength(150)]
        public string UserPassword { get; set; }

        [Column(TypeName = "bit", Order = 4)]
        public bool IsAdmin { get; set; }

    }
}