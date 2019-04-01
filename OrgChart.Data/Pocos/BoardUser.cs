using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("BoardUser", Schema = "ds")]
    public partial class BoardUser
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("ADUser")]
        [StringLength(100)]
        public string Aduser { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        [StringLength(11)]
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
