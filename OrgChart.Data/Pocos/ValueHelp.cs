using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("ValueHelp", Schema = "ds")]
    public partial class ValueHelp
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string ValueType { get; set; }
        [Required]
        [StringLength(20)]
        public string ValueKey { get; set; }
        [StringLength(100)]
        public string ValueText { get; set; }
        public int? Sequence { get; set; }
        [StringLength(20)]
        public string Status { get; set; }
        public DateTime? CreateDate { get; set; }
        [StringLength(100)]
        public string CreateBy { get; set; }
        public DateTime? LastModifyDate { get; set; }
        [StringLength(100)]
        public string LastModifyBy { get; set; }
    }
}
