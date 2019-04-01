using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("AttachmentRequest", Schema = "ds")]
    public partial class AttachmentRequest
    {
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(40)]
        public string ProcessCode { get; set; }
        [Column("DataID")]
        public int DataId { get; set; }
        [StringLength(20)]
        public string Status { get; set; }
        [StringLength(11)]
        public string RequestBy { get; set; }
        public DateTime? RequestDate { get; set; }
        [StringLength(11)]
        public string ResponseBy { get; set; }
        public DateTime? ResponseDate { get; set; }
    }
}
