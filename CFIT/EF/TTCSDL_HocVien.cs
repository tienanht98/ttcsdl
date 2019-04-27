namespace CFIT.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TTCSDL_HocVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TTCSDL_HocVien()
        {
            TTCDL_ThiSinh = new HashSet<TTCDL_ThiSinh>();
            TTCSDL_GiaOnThi = new HashSet<TTCSDL_GiaOnThi>();
        }

        [Key]
        public bool LaHocVien { get; set; }

        [Required]
        [StringLength(10)]
        public string HocTaiHocVien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TTCDL_ThiSinh> TTCDL_ThiSinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TTCSDL_GiaOnThi> TTCSDL_GiaOnThi { get; set; }
    }
}
