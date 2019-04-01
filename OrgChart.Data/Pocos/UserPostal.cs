using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("UserPostal", Schema = "ds")]
    public partial class UserPostal
    {
        [Key]
        [StringLength(11)]
        public string EmpNo { get; set; }
        [Required]
        [StringLength(100)]
        public string UserKey { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
