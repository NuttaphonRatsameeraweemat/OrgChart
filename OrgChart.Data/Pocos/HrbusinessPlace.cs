using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("HRBusinessPlace", Schema = "ds")]
    public partial class HrbusinessPlace
    {
        [StringLength(20)]
        public string BusinessPlace { get; set; }
        [StringLength(100)]
        public string BusinessPlaceName { get; set; }
        [StringLength(20)]
        public string ComCode { get; set; }
    }
}
