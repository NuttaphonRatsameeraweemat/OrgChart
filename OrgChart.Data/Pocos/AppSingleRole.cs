using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("AppSingleRole", Schema = "ds")]
    public partial class AppSingleRole
    {
        [Key]
        [Column("RoleID")]
        [StringLength(100)]
        public string RoleId { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
    }
}
