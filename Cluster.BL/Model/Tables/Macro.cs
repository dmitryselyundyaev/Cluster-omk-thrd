using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cluster.BL.Model.Tables
{
    [Table("Macro")]
    public class Macro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MacroId { get; set; }
        public virtual ICollection<OffsetData> Offsets { get; set; }
        public double? Offset { get; set; }
        public decimal? Conicity { get; set; }
        public decimal? Zajust { get; set; }
        public decimal? ThreadPass { get; set; }
        public decimal? OdSeal { get; set; }
        public decimal? Standoff { get; set; }

        public override string ToString()
        {
            return $"{MacroId}";
        }
    }
}
