using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cluster.BL.Model.Tables
{
    [Table("ProductType")]
    public class ProductType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        public virtual ICollection<OffsetData> Offsets { get; set; }
        public int Diameter { get; set; }
        public string ThreadType { get; set; }
        public override string ToString()
        {
            return $"{ProductId} Диаметр: {Diameter}, Тип резьбы: {ThreadType}";
        }
    }
}
