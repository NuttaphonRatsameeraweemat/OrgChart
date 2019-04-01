using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("CALockUserTransection", Schema = "ds")]
    public partial class CalockUserTransection
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("ADUser")]
        [StringLength(100)]
        public string Aduser { get; set; }
        [StringLength(255)]
        public string Action { get; set; }
        public DateTime? ActionDate { get; set; }
        [StringLength(100)]
        public string ActionBy { get; set; }
    }
}
