using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("WorkflowProcessInstance", Schema = "ds")]
    public partial class WorkflowProcessInstance
    {
        [Key]
        [Column("ProcessInstanceID")]
        public int ProcessInstanceId { get; set; }
        [StringLength(100)]
        public string ProcessCode { get; set; }
        [Column("DataID")]
        public int? DataId { get; set; }
        public int? CurrentStep { get; set; }
        [StringLength(20)]
        public string Status { get; set; }
    }
}
