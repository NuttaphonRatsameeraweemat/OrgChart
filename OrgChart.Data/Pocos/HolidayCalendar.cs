using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("HolidayCalendar", Schema = "ds")]
    public partial class HolidayCalendar
    {
        [Column("ID")]
        public int Id { get; set; }
        public short? Year { get; set; }
        public DateTime? HolidayDate { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }
        [StringLength(100)]
        public string CreateBy { get; set; }
        public DateTime? LastModifyDate { get; set; }
        [StringLength(100)]
        public string LastModifyBy { get; set; }
        public bool? PublicHoliday { get; set; }
    }
}
