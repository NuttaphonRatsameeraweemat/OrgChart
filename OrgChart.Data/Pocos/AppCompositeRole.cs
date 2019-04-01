using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("AppCompositeRole", Schema = "ds")]
    public partial class AppCompositeRole
    {
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        public string Description { get; set; }
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
