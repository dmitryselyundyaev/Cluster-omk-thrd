using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cluster.BL.Model.Tables
{
    [Table("OffsetData")]
    public class OffsetData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OffsetDataId { get; set; }
        [ForeignKey("Channel1")]
        public int ChannelOneId { get; set; }
        public virtual ChannelOne Channel1 { get; set; }
        [ForeignKey("Channel2")]
        public int ChannelTwoId { get; set; }
        public virtual ChannelTwo Channel2 { get; set; }
        [ForeignKey("Macro")]
        public int MacroId { get; set; }
        public virtual Macro Macro { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual UserData User { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual ProductType Product { get; set; }
        public string Comment { get; set; }
        public DateTime Created { get; set; }
        [Required]
        public string Machine { get; set; }

        public override string ToString()
        {
            return $"Станок:{Machine} | Сортамент:{Product.ThreadType}/{Product.Diameter} | От:{Created}";
        }
    }
}
