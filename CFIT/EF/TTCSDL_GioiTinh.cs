namespace CFIT.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TTCSDL_GioiTinh
    {
        [Key]
        public bool GioiTinh { get; set; }

        [Required]
        [StringLength(10)]
        public string LoaiGioiTInh { get; set; }
    }
}
