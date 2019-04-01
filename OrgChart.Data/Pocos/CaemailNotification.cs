using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("CAEmailNotification", Schema = "ds")]
    public partial class CaemailNotification
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("ADUser")]
        [StringLength(100)]
        public string Aduser { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        public DateTime? StartDate { get; set; }
        [StringLength(3)]
        public string IntervalType { get; set; }
        public int? IntervalDay { get; set; }
        [StringLength(100)]
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        [StringLength(100)]
        public string ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
