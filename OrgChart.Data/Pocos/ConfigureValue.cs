using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("ConfigureValue", Schema = "ds")]
    public partial class ConfigureValue
    {
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(20)]
        public string Key { get; set; }
        public string Description { get; set; }
        [StringLength(40)]
        public string Value { get; set; }
    }
}
