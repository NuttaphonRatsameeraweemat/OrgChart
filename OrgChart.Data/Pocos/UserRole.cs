using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("UserRole", Schema = "ds")]
    public partial class UserRole
    {
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(100)]
        public string Username { get; set; }
        [Column("CompositeRoleID")]
        public int? CompositeRoleId { get; set; }
        public DateTime? CreateDate { get; set; }
        [StringLength(100)]
        public string CreateBy { get; set; }
        public DateTime? LastModifyDate { get; set; }
        [StringLength(100)]
        public string LastModifyBy { get; set; }
    }
}
