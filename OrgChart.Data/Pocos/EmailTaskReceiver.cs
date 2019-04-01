using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("EmailTaskReceiver", Schema = "ds")]
    public partial class EmailTaskReceiver
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("EmailTaskID")]
        public int EmailTaskId { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        [StringLength(100)]
        public string FullName { get; set; }
        [Required]
        [StringLength(100)]
        public string ReceiverType { get; set; }
    }
}
