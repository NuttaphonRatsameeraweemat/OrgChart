using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("ConnectionLog", Schema = "ds")]
    public partial class ConnectionLog
    {
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(20)]
        public string LogType { get; set; }
        public DateTime? LogDate { get; set; }
        [StringLength(100)]
        public string User { get; set; }
        [Column("IP")]
        [StringLength(20)]
        public string Ip { get; set; }
        [StringLength(20)]
        public string Browser { get; set; }
        public string UserAgent { get; set; }
        [StringLength(20)]
        public string BrowserVersion { get; set; }
        [StringLength(20)]
        public string BrowserType { get; set; }
        public bool? IsMobile { get; set; }
        [StringLength(30)]
        public string MobileModel { get; set; }
        [StringLength(30)]
        public string MobileManufacturer { get; set; }
        [StringLength(50)]
        public string DocumentNo { get; set; }
    }
}
