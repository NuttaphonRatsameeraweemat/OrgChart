using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("HREmployee", Schema = "ds")]
    public partial class Hremployee
    {
        [StringLength(11)]
        public string EmpNo { get; set; }
        [Column("TitleTH")]
        [StringLength(20)]
        public string TitleTh { get; set; }
        [Column("FirstnameTH")]
        [StringLength(60)]
        public string FirstnameTh { get; set; }
        [Column("LastnameTH")]
        [StringLength(60)]
        public string LastnameTh { get; set; }
        [Column("TitleEN")]
        [StringLength(15)]
        public string TitleEn { get; set; }
        [Column("FirstnameEN")]
        [StringLength(60)]
        public string FirstnameEn { get; set; }
        [Column("LastnameEN")]
        [StringLength(60)]
        public string LastnameEn { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        [Column("ADUser")]
        [StringLength(100)]
        public string Aduser { get; set; }
        [StringLength(100)]
        public string MobileNo { get; set; }
        [StringLength(100)]
        public string OfficeTel { get; set; }
        [Column("IDCard")]
        [StringLength(30)]
        public string Idcard { get; set; }
        [StringLength(1)]
        public string EmpStatus { get; set; }
        [StringLength(5)]
        public string GradeCode { get; set; }
        [StringLength(60)]
        public string GradeText { get; set; }
        [Column("PositionID")]
        [StringLength(9)]
        public string PositionId { get; set; }
        [Column("OrgID")]
        [StringLength(9)]
        public string OrgId { get; set; }
        [StringLength(100)]
        public string ManagerEmpNo { get; set; }
        public DateTime? LastInterface { get; set; }
        [StringLength(10)]
        public string ComCode { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}
