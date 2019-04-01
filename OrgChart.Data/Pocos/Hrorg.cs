using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("HROrg", Schema = "ds")]
    public partial class Hrorg
    {
        [Key]
        [Column("OrgID")]
        [StringLength(8)]
        public string OrgId { get; set; }
        [StringLength(100)]
        public string OrgName { get; set; }
        [StringLength(100)]
        public string ManagerEmpNo { get; set; }
        public DateTime? LastInterface { get; set; }
        [StringLength(11)]
        public string OrgLevel { get; set; }
    }
}
