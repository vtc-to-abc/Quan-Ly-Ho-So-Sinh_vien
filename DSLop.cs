//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CMPM_QLyHoSoSinhVien
{
    using System;
    using System.Collections.Generic;
    
    public partial class DSLop
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DSLop()
        {
            this.DSSinhViens = new HashSet<DSSinhVien>();
        }
    
        public string id { get; set; }
        public string ThuocKhoa { get; set; }
        public Nullable<int> NienKhoa { get; set; }
        public string tenlop { get; set; }
        public string MaGvChuNhiem { get; set; }
    
        public virtual DSGiaoVien DSGiaoVien { get; set; }
        public virtual DSKhoa DSKhoa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DSSinhVien> DSSinhViens { get; set; }
    }
}
