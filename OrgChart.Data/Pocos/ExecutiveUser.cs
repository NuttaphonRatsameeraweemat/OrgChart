using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("ExecutiveUser", Schema = "ds")]
    public partial class ExecutiveUser
    {
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(11)]
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        [Column("ADUser")]
        [StringLength(40)]
        public string Aduser { get; set; }
        public bool? NoReport { get; set; }
    }
}
