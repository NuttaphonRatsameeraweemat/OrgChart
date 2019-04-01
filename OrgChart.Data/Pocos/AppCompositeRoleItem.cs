using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("AppCompositeRoleItem", Schema = "ds")]
    public partial class AppCompositeRoleItem
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("CompositeRoleID")]
        public int? CompositeRoleId { get; set; }
        [Column("RoleID")]
        [StringLength(100)]
        public string RoleId { get; set; }
    }
}
