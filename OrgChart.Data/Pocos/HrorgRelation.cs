using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("HROrgRelation", Schema = "ds")]
    public partial class HrorgRelation
    {
        [Column("ParentOrgID")]
        [StringLength(8)]
        public string ParentOrgId { get; set; }
        [StringLength(40)]
        public string ParentOrgName { get; set; }
        [Column("ChildOrgID")]
        [StringLength(8)]
        public string ChildOrgId { get; set; }
        [StringLength(40)]
        public string ChildOrgName { get; set; }
        public DateTime? LastInterface { get; set; }
    }
}
