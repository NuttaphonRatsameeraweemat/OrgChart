using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("BSPayee", Schema = "ds")]
    public partial class Bspayee
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("BSCompanyID")]
        public int? BscompanyId { get; set; }
        public int? Seq { get; set; }
        [StringLength(10)]
        public string ComCode { get; set; }
        [Column("TopicID")]
        public int? TopicId { get; set; }
        [StringLength(40)]
        public string BankAccount { get; set; }
        [StringLength(20)]
        public string FiDoc { get; set; }
        [Column("PayeeTaxID")]
        [StringLength(40)]
        public string PayeeTaxId { get; set; }
        [StringLength(100)]
        public string PayeeName { get; set; }
        [Column(TypeName = "decimal(20, 4)")]
        public decimal? Amount { get; set; }
        [StringLength(20)]
        public string Status { get; set; }
    }
}
