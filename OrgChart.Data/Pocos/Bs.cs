using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("BS", Schema = "ds")]
    public partial class Bs
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("BSNo")]
        [StringLength(16)]
        public string Bsno { get; set; }
        [Column("BSDate")]
        public DateTime? Bsdate { get; set; }
        [StringLength(12)]
        public string BankCode { get; set; }
        [StringLength(10)]
        public string ProductCode { get; set; }
        public string To { get; set; }
        public string Topic { get; set; }
        [StringLength(20)]
        public string Status { get; set; }
        [StringLength(11)]
        public string CreateBy { get; set; }
        [StringLength(9)]
        public string CreatePos { get; set; }
        [StringLength(9)]
        public string CreateOrg { get; set; }
        public DateTime? CreateDate { get; set; }
        [StringLength(11)]
        public string LastModifyBy { get; set; }
        public DateTime? LastModifyDate { get; set; }
        public string TopicDate { get; set; }
        public string TopicDetail { get; set; }
    }
}
