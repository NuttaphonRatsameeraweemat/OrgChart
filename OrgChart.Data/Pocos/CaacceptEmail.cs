using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("CAAcceptEmail", Schema = "ds")]
    public partial class CaacceptEmail
    {
        [Column("ID")]
        public int Id { get; set; }
        public DateTime? SendEmailDate { get; set; }
        [StringLength(20)]
        public string Status { get; set; }
        [Column("CAList")]
        [StringLength(255)]
        public string Calist { get; set; }
        [Column("ToADUser")]
        [StringLength(100)]
        public string ToAduser { get; set; }
        [StringLength(100)]
        public string ActionBy { get; set; }
        public DateTime? ActionDate { get; set; }
        public bool? IsCount { get; set; }
    }
}
