using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("CALockUser", Schema = "ds")]
    public partial class CalockUser
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("ADUser")]
        [StringLength(100)]
        public string Aduser { get; set; }
        public bool? IsLock { get; set; }
    }
}
