namespace CFIT.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TTCSDL_GioiTinh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TTCSDL_GioiTinh()
        {
            TTCDL_ThiSinh = new HashSet<TTCDL_ThiSinh>();
        }

        [Key]
        public bool GioiTinh { get; set; }

        [Required]
        [StringLength(10)]
        public string LoaiGioiTInh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TTCDL_ThiSinh> TTCDL_ThiSinh { get; set; }
    }
}
