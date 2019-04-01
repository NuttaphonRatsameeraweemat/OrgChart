using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("RespGroupOrg", Schema = "ds")]
    public partial class RespGroupOrg
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("RespGroupID")]
        public int? RespGroupId { get; set; }
        [Column("OrgID")]
        [StringLength(8)]
        public string OrgId { get; set; }
    }
}
