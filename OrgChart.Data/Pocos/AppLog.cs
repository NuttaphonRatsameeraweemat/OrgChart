using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("AppLog", Schema = "ds")]
    public partial class AppLog
    {
        [Column("ID")]
        public int Id { get; set; }
        public DateTime? LogDate { get; set; }
        [StringLength(200)]
        public string LogBy { get; set; }
        [StringLength(200)]
        public string Method { get; set; }
        public string Message { get; set; }
        public string Data1 { get; set; }
        public string Data2 { get; set; }
    }
}
