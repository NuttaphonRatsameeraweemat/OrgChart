using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("EmailTask", Schema = "ds")]
    public partial class EmailTask
    {
        [Column("ID")]
        public int Id { get; set; }
        public DateTime TaskDate { get; set; }
        [Required]
        [StringLength(4)]
        public string TaskCode { get; set; }
        [Required]
        [StringLength(40)]
        public string TaskBy { get; set; }
        [Required]
        [StringLength(20)]
        public string DocNo { get; set; }
        [Required]
        [StringLength(100)]
        public string Subject { get; set; }
        [Required]
        [StringLength(20)]
        public string Status { get; set; }
    }
}
