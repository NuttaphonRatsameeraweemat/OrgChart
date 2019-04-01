using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("PVGroup", Schema = "ds")]
    public partial class Pvgroup
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("PVGroupNo")]
        [StringLength(12)]
        public string PvgroupNo { get; set; }
        [Column("PVGroupType")]
        [StringLength(20)]
        public string PvgroupType { get; set; }
        [Column("PVGroupDate")]
        public DateTime? PvgroupDate { get; set; }
        public string Remark { get; set; }
        [StringLength(11)]
        public string CreateBy { get; set; }
        [StringLength(11)]
        public string CreatePos { get; set; }
        [StringLength(11)]
        public string CreateOrg { get; set; }
        public DateTime? CreateDate { get; set; }
        [StringLength(100)]
        public string OrgName { get; set; }
        [StringLength(10)]
        public string ComCode { get; set; }
    }
}
