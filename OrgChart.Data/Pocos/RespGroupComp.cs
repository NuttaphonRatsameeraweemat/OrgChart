using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("RespGroupComp", Schema = "ds")]
    public partial class RespGroupComp
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("RespGroupID")]
        public int? RespGroupId { get; set; }
        [StringLength(10)]
        public string ComCode { get; set; }
    }
}
