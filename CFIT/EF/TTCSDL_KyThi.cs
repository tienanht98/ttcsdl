namespace CFIT.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TTCSDL_KyThi
    {
        [Key]
        [StringLength(10)]
        public string MaKyThi { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayThi { get; set; }
    }
}
