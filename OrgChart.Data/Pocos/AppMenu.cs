using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("AppMenu", Schema = "ds")]
    public partial class AppMenu
    {
        [Key]
        [StringLength(100)]
        public string MenuCode { get; set; }
        [StringLength(200)]
        public string ResourceName { get; set; }
        [StringLength(20)]
        public string MenuType { get; set; }
        [StringLength(100)]
        public string ParentMenuCode { get; set; }
        public int? Sequence { get; set; }
        [StringLength(100)]
        public string RoleForManage { get; set; }
        [StringLength(100)]
        public string RoleForDisplay { get; set; }
        [StringLength(100)]
        public string Controller { get; set; }
        [StringLength(100)]
        public string Action { get; set; }
        [StringLength(100)]
        public string Area { get; set; }
        [StringLength(100)]
        public string Icon { get; set; }
    }
}
