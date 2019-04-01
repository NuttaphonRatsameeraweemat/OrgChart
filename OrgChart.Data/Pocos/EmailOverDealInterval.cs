using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("EmailOverDealInterval", Schema = "ds")]
    public partial class EmailOverDealInterval
    {
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(3)]
        public string IntervalType { get; set; }
        public int? IntervalDay { get; set; }
        [StringLength(100)]
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        [StringLength(100)]
        public string ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public DateTime? StartDate { get; set; }
    }
}
