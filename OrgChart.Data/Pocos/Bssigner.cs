using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("BSSigner", Schema = "ds")]
    public partial class Bssigner
    {
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(11)]
        public string Signer { get; set; }
        [StringLength(30)]
        public string Activity { get; set; }
        [StringLength(10)]
        public string ComCode { get; set; }
    }
}
