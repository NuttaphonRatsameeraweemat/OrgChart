using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("AuthorityCompany", Schema = "ds")]
    public partial class AuthorityCompany
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("ADUser")]
        [StringLength(100)]
        public string Aduser { get; set; }
        [Column("BRB")]
        public bool? Brb { get; set; }
        [Column("BRT")]
        public bool? Brt { get; set; }
        [Column("SCO")]
        public bool? Sco { get; set; }
        [StringLength(11)]
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
