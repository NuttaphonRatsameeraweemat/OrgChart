using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("PVActivitySAP", Schema = "ds")]
    public partial class PvactivitySap
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("PVNo")]
        [StringLength(12)]
        public string Pvno { get; set; }
        [Column("ProcessInstanceID")]
        public int? ProcessInstanceId { get; set; }
        [StringLength(16)]
        public string Step { get; set; }
        [StringLength(100)]
        public string Activity { get; set; }
        [Column("ActionID")]
        [StringLength(100)]
        public string ActionId { get; set; }
        [StringLength(10)]
        public string ActionType { get; set; }
        [StringLength(100)]
        public string Action { get; set; }
        [StringLength(100)]
        public string ActionName { get; set; }
        public DateTime? ActionDate { get; set; }
        public string Comment { get; set; }
        [StringLength(100)]
        public string AllocateUser { get; set; }
        [Column("PVSAPID")]
        public int? Pvsapid { get; set; }
    }
}
