using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("PVSAP", Schema = "ds")]
    public partial class Pvsap
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("PVNo")]
        [StringLength(12)]
        public string Pvno { get; set; }
        [Column("PVType")]
        [StringLength(20)]
        public string Pvtype { get; set; }
        [Column("CANo")]
        [StringLength(150)]
        public string Cano { get; set; }
        [StringLength(10)]
        public string ComCode { get; set; }
        [Column("PayID")]
        [StringLength(11)]
        public string PayId { get; set; }
        [StringLength(80)]
        public string Section { get; set; }
        [Column("PVCostCenter")]
        [StringLength(10)]
        public string PvcostCenter { get; set; }
        [StringLength(8)]
        public string PayOrg { get; set; }
        public string PayAddress { get; set; }
        public DateTime? PayDate { get; set; }
        public DateTime? PrintDate { get; set; }
        [Column(TypeName = "decimal(20, 4)")]
        public decimal? Amount { get; set; }
        [Column("VAT", TypeName = "decimal(20, 4)")]
        public decimal? Vat { get; set; }
        [Column("WHT", TypeName = "decimal(20, 4)")]
        public decimal? Wht { get; set; }
        [Column(TypeName = "decimal(20, 4)")]
        public decimal? TotalAmount { get; set; }
        [Column("CAAmount", TypeName = "decimal(20, 4)")]
        public decimal? Caamount { get; set; }
        [Column(TypeName = "decimal(20, 4)")]
        public decimal? NetAmount { get; set; }
        [Column("ClearCANo")]
        [StringLength(12)]
        public string ClearCano { get; set; }
        public string Note { get; set; }
        [Column(TypeName = "decimal(20, 4)")]
        public decimal? TotalInvoice { get; set; }
        [Column("TotalVAT", TypeName = "decimal(20, 4)")]
        public decimal? TotalVat { get; set; }
        [Column(TypeName = "decimal(20, 4)")]
        public decimal? TotalPay { get; set; }
        [Column("TotalWHT1", TypeName = "decimal(20, 4)")]
        public decimal? TotalWht1 { get; set; }
        [Column("TotalWHT2", TypeName = "decimal(20, 4)")]
        public decimal? TotalWht2 { get; set; }
        [Column("TotalWHT3", TypeName = "decimal(20, 4)")]
        public decimal? TotalWht3 { get; set; }
        [StringLength(20)]
        public string Status { get; set; }
        [StringLength(20)]
        public string Special { get; set; }
        public DateTime? LastInterface { get; set; }
        public string Message { get; set; }
        [Column("PVSAPID")]
        public int? Pvsapid { get; set; }
        [StringLength(100)]
        public string AttachedFile { get; set; }
        [StringLength(150)]
        public string PayName { get; set; }
        [StringLength(30)]
        public string PrepareByDept { get; set; }
        [StringLength(3)]
        public string Currency { get; set; }
        [StringLength(40)]
        public string ExchangeRate { get; set; }
    }
}
