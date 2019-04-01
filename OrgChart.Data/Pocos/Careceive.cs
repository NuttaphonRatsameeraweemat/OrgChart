using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("CAReceive", Schema = "ds")]
    public partial class Careceive
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("CANo")]
        [StringLength(15)]
        public string Cano { get; set; }
        [Column("CAReceiveDate")]
        public DateTime? CareceiveDate { get; set; }
        [Column("TitleTH")]
        [StringLength(20)]
        public string TitleTh { get; set; }
        [Column("FirstNameTH")]
        [StringLength(80)]
        public string FirstNameTh { get; set; }
        [Column("MiddleNameTH")]
        [StringLength(80)]
        public string MiddleNameTh { get; set; }
        [Column("LastNameTH")]
        [StringLength(80)]
        public string LastNameTh { get; set; }
        [Column("TitleEN")]
        [StringLength(20)]
        public string TitleEn { get; set; }
        [Column("FirstNameEN")]
        [StringLength(20)]
        public string FirstNameEn { get; set; }
        [Column("MiddleNameEN")]
        [StringLength(80)]
        public string MiddleNameEn { get; set; }
        [Column("LastNameEN")]
        [StringLength(80)]
        public string LastNameEn { get; set; }
        [StringLength(80)]
        public string No { get; set; }
        [StringLength(80)]
        public string Moo { get; set; }
        [StringLength(80)]
        public string Trok { get; set; }
        [StringLength(80)]
        public string Soi { get; set; }
        [StringLength(80)]
        public string Tanon { get; set; }
        [StringLength(80)]
        public string Tambon { get; set; }
        [StringLength(80)]
        public string Amper { get; set; }
        [StringLength(80)]
        public string Jangwat { get; set; }
        [StringLength(80)]
        public string ExpiryDate { get; set; }
        [StringLength(80)]
        public string Photo { get; set; }
    }
}
