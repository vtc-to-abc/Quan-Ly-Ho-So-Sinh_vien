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
    
    public partial class DSLopHocPhan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DSLopHocPhan()
        {
            this.DSSinhViens = new HashSet<DSSinhVien>();
        }
    
        public string MaLopHocPhan { get; set; }
        public string MaMonHoc { get; set; }
        public Nullable<int> SoLuongSV { get; set; }
        public Nullable<int> HocKi { get; set; }
        public string GiaoVienGiangDay { get; set; }
    
        public virtual DSGiaoVien DSGiaoVien { get; set; }
        public virtual DSMonHoc DSMonHoc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DSSinhVien> DSSinhViens { get; set; }
    }
}
