using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("CompanyManager", Schema = "ds")]
    public partial class CompanyManager
    {
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(10)]
        public string ComCode { get; set; }
        [StringLength(10)]
        public string Status { get; set; }
    }
}
