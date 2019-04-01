using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("EmailTaskContent", Schema = "ds")]
    public partial class EmailTaskContent
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("EmailTaskID")]
        public int EmailTaskId { get; set; }
        [Required]
        public string Content { get; set; }
    }
}
