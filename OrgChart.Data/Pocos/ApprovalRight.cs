using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("ApprovalRight", Schema = "ds")]
    public partial class ApprovalRight
    {
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(11)]
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        [Column("ADUser")]
        [StringLength(40)]
        public string Aduser { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        [StringLength(10)]
        public string ComCode { get; set; }
        [Column("OrgID")]
        [StringLength(8)]
        public string OrgId { get; set; }
    }
}
