using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("OTP", Schema = "ds")]
    public partial class Otp
    {
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(11)]
        public string EmpNo { get; set; }
        public DateTime? CommitDate { get; set; }
        [StringLength(20)]
        public string Status { get; set; }
        [StringLength(20)]
        public string MobileNo { get; set; }
    }
}
