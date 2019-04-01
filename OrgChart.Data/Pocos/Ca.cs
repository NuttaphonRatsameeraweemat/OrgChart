using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("CA", Schema = "ds")]
    public partial class Ca
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("CANo")]
        [StringLength(15)]
        public string Cano { get; set; }
        [Column("CADate")]
        public DateTime? Cadate { get; set; }
        [Column("FundSAP")]
        [StringLength(25)]
        public string FundSap { get; set; }
        [Column("IOSAP")]
        [StringLength(25)]
        public string Iosap { get; set; }
        [StringLength(10)]
        public string ComCode { get; set; }
        [StringLength(10)]
        public string CostCenter { get; set; }
        [StringLength(20)]
        public string ReserveBudget { get; set; }
        [StringLength(50)]
        public string InternalMemoNo { get; set; }
        [StringLength(80)]
        public string Objective { get; set; }
        public string ObjectiveDesc { get; set; }
        [Column(TypeName = "decimal(20, 4)")]
        public decimal? Amount { get; set; }
        [StringLength(3)]
        public string Currency { get; set; }
        public DateTime? RequireDate { get; set; }
        public DateTime? ReceiveDate { get; set; }
        public DateTime? DueDate { get; set; }
        [Column("ReceiveID")]
        [StringLength(13)]
        public string ReceiveId { get; set; }
        [StringLength(20)]
        public string BusinessPlace { get; set; }
        [StringLength(20)]
        public string PaymentPlace { get; set; }
        public string Remark { get; set; }
        [StringLength(20)]
        public string Status { get; set; }
        [StringLength(11)]
        public string PrepareBy { get; set; }
        public DateTime? RequestDate { get; set; }
        [StringLength(11)]
        public string RequestFor { get; set; }
        [StringLength(9)]
        public string RequestPos { get; set; }
        [StringLength(9)]
        public string RequestOrg { get; set; }
        [StringLength(11)]
        public string CreateBy { get; set; }
        [StringLength(9)]
        public string CreatePos { get; set; }
        [StringLength(9)]
        public string CreateOrg { get; set; }
        public DateTime? CreateDate { get; set; }
        [StringLength(11)]
        public string LastModifyBy { get; set; }
        public DateTime? LastModifyDate { get; set; }
        [Column("SAPMessage")]
        public string Sapmessage { get; set; }
        [StringLength(2)]
        public string ReceiveType { get; set; }
        public bool? Executive { get; set; }
        public string ReceiveRemark { get; set; }
    }
}
