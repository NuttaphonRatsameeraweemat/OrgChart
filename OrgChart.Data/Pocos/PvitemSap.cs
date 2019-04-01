using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("PVItemSAP", Schema = "ds")]
    public partial class PvitemSap
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("PVNo")]
        [StringLength(12)]
        public string Pvno { get; set; }
        public int? Seq { get; set; }
        [StringLength(16)]
        public string DocNo { get; set; }
        [StringLength(20)]
        public string Ref { get; set; }
        public DateTime? InvoiceDate { get; set; }
        [Column("DocHT")]
        [StringLength(80)]
        public string DocHt { get; set; }
        [Column("ST")]
        [StringLength(20)]
        public string St { get; set; }
        public DateTime? EntryDate { get; set; }
        [StringLength(20)]
        public string At1 { get; set; }
        [Column(TypeName = "decimal(20, 4)")]
        public decimal? Invoice { get; set; }
        [StringLength(20)]
        public string At2 { get; set; }
        [Column("VAT", TypeName = "decimal(20, 4)")]
        public decimal? Vat { get; set; }
        [StringLength(20)]
        public string At3 { get; set; }
        [Column("PAY", TypeName = "decimal(20, 4)")]
        public decimal? Pay { get; set; }
        [Column("VendorID")]
        [StringLength(11)]
        public string VendorId { get; set; }
        [StringLength(80)]
        public string VendorName { get; set; }
        [Column("PayeeID")]
        [StringLength(11)]
        public string PayeeId { get; set; }
        [StringLength(150)]
        public string PayeeName { get; set; }
        [Column("RT")]
        [StringLength(10)]
        public string Rt { get; set; }
        [Column(TypeName = "decimal(20, 4)")]
        public decimal? Percent1 { get; set; }
        [Column("WHT1", TypeName = "decimal(20, 4)")]
        public decimal? Wht1 { get; set; }
        [Column(TypeName = "decimal(20, 4)")]
        public decimal? Percent2 { get; set; }
        [Column("WHT2", TypeName = "decimal(20, 4)")]
        public decimal? Wht2 { get; set; }
        [Column(TypeName = "decimal(20, 4)")]
        public decimal? Percent3 { get; set; }
        [Column("WHT3", TypeName = "decimal(20, 4)")]
        public decimal? Wht3 { get; set; }
        [Column("PVSAPID")]
        public int? Pvsapid { get; set; }
    }
}
