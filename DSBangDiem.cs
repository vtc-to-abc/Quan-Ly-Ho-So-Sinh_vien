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
    
    public partial class DSBangDiem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DSBangDiem()
        {
            this.ChiTietBangDiems = new HashSet<ChiTietBangDiem>();
        }
    
        public string MaBangDiem { get; set; }
        public string MaSV { get; set; }
        public Nullable<int> HocKi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietBangDiem> ChiTietBangDiems { get; set; }
        public virtual DSSinhVien DSSinhVien { get; set; }
    }
}
