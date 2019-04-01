using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("PVGroupItem", Schema = "ds")]
    public partial class PvgroupItem
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("PVGroupNo")]
        [StringLength(12)]
        public string PvgroupNo { get; set; }
        [Column("PVNo")]
        [StringLength(12)]
        public string Pvno { get; set; }
        [StringLength(10)]
        public string ComCode { get; set; }
    }
}
