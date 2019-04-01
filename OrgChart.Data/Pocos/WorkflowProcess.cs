using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("WorkflowProcess", Schema = "ds")]
    public partial class WorkflowProcess
    {
        [Key]
        [StringLength(100)]
        public string ProcessCode { get; set; }
        [StringLength(200)]
        public string ProcessName { get; set; }
        [Column("K2WorkflowProcess")]
        [StringLength(100)]
        public string K2workflowProcess { get; set; }
        [StringLength(100)]
        public string Controller { get; set; }
        [StringLength(100)]
        public string Action { get; set; }
        [StringLength(100)]
        public string Area { get; set; }
        public bool? AllowConfig { get; set; }
        public bool? RejectToInbox { get; set; }
    }
}
