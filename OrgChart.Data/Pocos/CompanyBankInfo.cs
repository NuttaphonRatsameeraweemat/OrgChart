using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("CompanyBankInfo", Schema = "ds")]
    public partial class CompanyBankInfo
    {
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(10)]
        public string ComCode { get; set; }
        [StringLength(10)]
        public string BankCode { get; set; }
        [StringLength(80)]
        public string BankName { get; set; }
        [StringLength(10)]
        public string BankBranchCode { get; set; }
        [StringLength(80)]
        public string BankBranchName { get; set; }
        [StringLength(10)]
        public string AccountType { get; set; }
        [StringLength(80)]
        public string AccountName { get; set; }
        [StringLength(20)]
        public string AccountNumber { get; set; }
    }
}
