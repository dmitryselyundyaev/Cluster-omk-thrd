using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cluster.BL.Model.Tables
{
    [Table("UserData")]
    public class UserData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Required]
        public string UserName { get; set; }

        public int OffsetDataId;
        public virtual ICollection<OffsetData> Offsets { get; set; }

        public string UserPassword { get; set; }
        public override string ToString()
        {
            return $"{UserName}";
        }
    }
}
