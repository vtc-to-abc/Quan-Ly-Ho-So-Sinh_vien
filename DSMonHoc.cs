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
    
    public partial class DSMonHoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DSMonHoc()
        {
            this.ChiTietBangDiems = new HashSet<ChiTietBangDiem>();
            this.DSLopHocPhans = new HashSet<DSLopHocPhan>();
        }
    
        public string MaMonHoc { get; set; }
        public string TenMonHoc { get; set; }
        public Nullable<int> SoTinChi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietBangDiem> ChiTietBangDiems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DSLopHocPhan> DSLopHocPhans { get; set; }
    }
}
