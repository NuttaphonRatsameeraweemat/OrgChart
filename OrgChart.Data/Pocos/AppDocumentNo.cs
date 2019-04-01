using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("AppDocumentNo", Schema = "ds")]
    public partial class AppDocumentNo
    {
        [StringLength(100)]
        public string ProcessCode { get; set; }
        [StringLength(50)]
        public string DocumentNoPrefix { get; set; }
        public int? LastRunningNo { get; set; }
        public int? RunningNoDigit { get; set; }
        public short Year { get; set; }
        [StringLength(20)]
        public string Additional01 { get; set; }
        [StringLength(20)]
        public string Additional02 { get; set; }
        [StringLength(20)]
        public string Additional03 { get; set; }
    }
}
