using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("ReviewManager", Schema = "ds")]
    public partial class ReviewManager
    {
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(11)]
        public string Manager { get; set; }
        [StringLength(10)]
        public string Status { get; set; }
    }
}
