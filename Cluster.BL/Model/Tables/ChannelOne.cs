using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cluster.BL.Model.Tables
{
    [Table("ChannelOne")]
    public class ChannelOne
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Channel1Id { get; set; }
        public virtual ICollection<OffsetData> Offsets { get; set; }
        public decimal? X1 { get; set; }
        public decimal? Z1 { get; set; }
        public decimal? X2 { get; set; }
        public decimal? Z2 { get; set; }
        public decimal? X3 { get; set; }
        public decimal? Z3 { get; set; }
        public decimal? X4 { get; set; }
        public decimal? Z4 { get; set; }
        public decimal? X5 { get; set; }
        public decimal? Z5 { get; set; }
        public decimal? X6 { get; set; }
        public decimal? Z6 { get; set; }
        public decimal? X7 { get; set; }
        public decimal? Z7 { get; set; }
        public decimal? Y1 { get; set; }
        public decimal? Y2 { get; set; }
        public decimal? Y3 { get; set; }
        public decimal? Y4 { get; set; }
        public decimal? Y5 { get; set; }
        public override string ToString()
        {
            return $"{Channel1Id}";
        }
    }
}
