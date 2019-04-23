namespace CFIT.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TTCSDL_TrinhDo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TTCSDL_TrinhDo()
        {
            TTCSDL_GiaOnThi = new HashSet<TTCSDL_GiaOnThi>();
        }

        [Key]
        public bool TrinhDo { get; set; }

        [Required]
        [StringLength(50)]
        public string LoaiTrinhDo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TTCSDL_GiaOnThi> TTCSDL_GiaOnThi { get; set; }
    }
}
