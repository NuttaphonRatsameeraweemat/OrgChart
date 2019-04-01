using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("ReviewManagerItem", Schema = "ds")]
    public partial class ReviewManagerItem
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("ReviewManagerID")]
        public int? ReviewManagerId { get; set; }
        [StringLength(11)]
        public string Reviewer { get; set; }
        [StringLength(10)]
        public string ComCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
