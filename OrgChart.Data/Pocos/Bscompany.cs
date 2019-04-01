using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("BSCompany", Schema = "ds")]
    public partial class Bscompany
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("BSNo")]
        [StringLength(16)]
        public string Bsno { get; set; }
        public int? Seq { get; set; }
        [StringLength(10)]
        public string ComCode { get; set; }
        public string Topic { get; set; }
        public DateTime? ValueDate { get; set; }
        [Column("TotalNoCR")]
        public int? TotalNoCr { get; set; }
        public string BankAccount { get; set; }
        [Column(TypeName = "decimal(20, 4)")]
        public decimal? DebitAmount { get; set; }
        public DateTime? ExportDate { get; set; }
    }
}
