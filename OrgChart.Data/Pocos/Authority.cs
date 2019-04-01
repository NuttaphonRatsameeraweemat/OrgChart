using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("Authority", Schema = "ds")]
    public partial class Authority
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string EmpNo { get; set; }
        [Required]
        [StringLength(10)]
        public string ComCode { get; set; }
        [Column(TypeName = "decimal(20, 4)")]
        public decimal? Remark1 { get; set; }
        [Column(TypeName = "decimal(20, 4)")]
        public decimal? Remark2 { get; set; }
        [Column(TypeName = "decimal(20, 4)")]
        public decimal? Remark3 { get; set; }
        [Column(TypeName = "decimal(20, 4)")]
        public decimal? Remark4 { get; set; }
        [Column(TypeName = "decimal(20, 4)")]
        public decimal? Remark5 { get; set; }
        [StringLength(20)]
        public string Status { get; set; }
        public DateTime? LastInterface { get; set; }
    }
}
