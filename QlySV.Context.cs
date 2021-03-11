﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class QuanLyHoSoSinhVienEntities4 : DbContext
    {
        public QuanLyHoSoSinhVienEntities4()
            : base("name=QuanLyHoSoSinhVienEntities4")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ChiTietBangDiem> ChiTietBangDiems { get; set; }
        public virtual DbSet<DSBangDiem> DSBangDiems { get; set; }
        public virtual DbSet<DSGiaoVien> DSGiaoViens { get; set; }
        public virtual DbSet<DSKhoa> DSKhoas { get; set; }
        public virtual DbSet<DSLop> DSLops { get; set; }
        public virtual DbSet<DSLopHocPhan> DSLopHocPhans { get; set; }
        public virtual DbSet<DSMonHoc> DSMonHocs { get; set; }
        public virtual DbSet<DSSinhVien> DSSinhViens { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
    
        public virtual int Sua_SinhVien_Diem(string masv, string lophp, Nullable<double> dcc, Nullable<double> dtx, Nullable<double> dt)
        {
            var masvParameter = masv != null ?
                new ObjectParameter("masv", masv) :
                new ObjectParameter("masv", typeof(string));
    
            var lophpParameter = lophp != null ?
                new ObjectParameter("lophp", lophp) :
                new ObjectParameter("lophp", typeof(string));
    
            var dccParameter = dcc.HasValue ?
                new ObjectParameter("dcc", dcc) :
                new ObjectParameter("dcc", typeof(double));
    
            var dtxParameter = dtx.HasValue ?
                new ObjectParameter("dtx", dtx) :
                new ObjectParameter("dtx", typeof(double));
    
            var dtParameter = dt.HasValue ?
                new ObjectParameter("dt", dt) :
                new ObjectParameter("dt", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sua_SinhVien_Diem", masvParameter, lophpParameter, dccParameter, dtxParameter, dtParameter);
        }
    
        public virtual int Sua_SinhVien_HoSo(string masv, string ten, Nullable<System.DateTime> dob, string sdt, string gt, string qq, string mail, string lop)
        {
            var masvParameter = masv != null ?
                new ObjectParameter("masv", masv) :
                new ObjectParameter("masv", typeof(string));
    
            var tenParameter = ten != null ?
                new ObjectParameter("ten", ten) :
                new ObjectParameter("ten", typeof(string));
    
            var dobParameter = dob.HasValue ?
                new ObjectParameter("dob", dob) :
                new ObjectParameter("dob", typeof(System.DateTime));
    
            var sdtParameter = sdt != null ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(string));
    
            var gtParameter = gt != null ?
                new ObjectParameter("gt", gt) :
                new ObjectParameter("gt", typeof(string));
    
            var qqParameter = qq != null ?
                new ObjectParameter("qq", qq) :
                new ObjectParameter("qq", typeof(string));
    
            var mailParameter = mail != null ?
                new ObjectParameter("mail", mail) :
                new ObjectParameter("mail", typeof(string));
    
            var lopParameter = lop != null ?
                new ObjectParameter("lop", lop) :
                new ObjectParameter("lop", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sua_SinhVien_HoSo", masvParameter, tenParameter, dobParameter, sdtParameter, gtParameter, qqParameter, mailParameter, lopParameter);
        }
    
        public virtual ObjectResult<xuat_AllSinhVien_Result> xuat_AllSinhVien()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<xuat_AllSinhVien_Result>("xuat_AllSinhVien");
        }
    
        public virtual ObjectResult<xuat_AllSinhVien_DiemTB_CaKi_Result> xuat_AllSinhVien_DiemTB_CaKi(Nullable<int> ki)
        {
            var kiParameter = ki.HasValue ?
                new ObjectParameter("ki", ki) :
                new ObjectParameter("ki", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<xuat_AllSinhVien_DiemTB_CaKi_Result>("xuat_AllSinhVien_DiemTB_CaKi", kiParameter);
        }
    
        public virtual ObjectResult<xuat_DSDiem_SinhVien_Ki_Result> xuat_DSDiem_SinhVien_Ki(string masv, Nullable<int> ki)
        {
            var masvParameter = masv != null ?
                new ObjectParameter("masv", masv) :
                new ObjectParameter("masv", typeof(string));
    
            var kiParameter = ki.HasValue ?
                new ObjectParameter("ki", ki) :
                new ObjectParameter("ki", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<xuat_DSDiem_SinhVien_Ki_Result>("xuat_DSDiem_SinhVien_Ki", masvParameter, kiParameter);
        }
    
        public virtual ObjectResult<xuat_GiaoVien_DSHocPhan_TaiKhoan_Result> xuat_GiaoVien_DSHocPhan_TaiKhoan(string taikhoan)
        {
            var taikhoanParameter = taikhoan != null ?
                new ObjectParameter("taikhoan", taikhoan) :
                new ObjectParameter("taikhoan", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<xuat_GiaoVien_DSHocPhan_TaiKhoan_Result>("xuat_GiaoVien_DSHocPhan_TaiKhoan", taikhoanParameter);
        }
    
        public virtual ObjectResult<string> xuat_GiaoVien_TaiKhoan(string taikhoan)
        {
            var taikhoanParameter = taikhoan != null ?
                new ObjectParameter("taikhoan", taikhoan) :
                new ObjectParameter("taikhoan", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("xuat_GiaoVien_TaiKhoan", taikhoanParameter);
        }
    
        public virtual ObjectResult<xuat_SinhVien_Diem_HocPhan_Result> xuat_SinhVien_Diem_HocPhan(string masv, string mahocphan)
        {
            var masvParameter = masv != null ?
                new ObjectParameter("masv", masv) :
                new ObjectParameter("masv", typeof(string));
    
            var mahocphanParameter = mahocphan != null ?
                new ObjectParameter("mahocphan", mahocphan) :
                new ObjectParameter("mahocphan", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<xuat_SinhVien_Diem_HocPhan_Result>("xuat_SinhVien_Diem_HocPhan", masvParameter, mahocphanParameter);
        }
    
        public virtual ObjectResult<xuat_SinhVien_Diem_Ki_Result> xuat_SinhVien_Diem_Ki(string masv, Nullable<int> ki)
        {
            var masvParameter = masv != null ?
                new ObjectParameter("masv", masv) :
                new ObjectParameter("masv", typeof(string));
    
            var kiParameter = ki.HasValue ?
                new ObjectParameter("ki", ki) :
                new ObjectParameter("ki", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<xuat_SinhVien_Diem_Ki_Result>("xuat_SinhVien_Diem_Ki", masvParameter, kiParameter);
        }
    
        public virtual ObjectResult<Nullable<double>> xuat_SinhVien_DiemTB_CaKi(string masv, Nullable<int> ki)
        {
            var masvParameter = masv != null ?
                new ObjectParameter("masv", masv) :
                new ObjectParameter("masv", typeof(string));
    
            var kiParameter = ki.HasValue ?
                new ObjectParameter("ki", ki) :
                new ObjectParameter("ki", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<double>>("xuat_SinhVien_DiemTB_CaKi", masvParameter, kiParameter);
        }
    
        public virtual ObjectResult<xuat_SinhVien_DiemTB_CaKi_Lop_Result> xuat_SinhVien_DiemTB_CaKi_Lop(string lop, Nullable<int> ki)
        {
            var lopParameter = lop != null ?
                new ObjectParameter("lop", lop) :
                new ObjectParameter("lop", typeof(string));
    
            var kiParameter = ki.HasValue ?
                new ObjectParameter("ki", ki) :
                new ObjectParameter("ki", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<xuat_SinhVien_DiemTB_CaKi_Lop_Result>("xuat_SinhVien_DiemTB_CaKi_Lop", lopParameter, kiParameter);
        }
    
        public virtual ObjectResult<xuat_SinhVien_DiemTB_CaKi_LopHocPhan_Result> xuat_SinhVien_DiemTB_CaKi_LopHocPhan(string lop, Nullable<int> ki)
        {
            var lopParameter = lop != null ?
                new ObjectParameter("lop", lop) :
                new ObjectParameter("lop", typeof(string));
    
            var kiParameter = ki.HasValue ?
                new ObjectParameter("ki", ki) :
                new ObjectParameter("ki", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<xuat_SinhVien_DiemTB_CaKi_LopHocPhan_Result>("xuat_SinhVien_DiemTB_CaKi_LopHocPhan", lopParameter, kiParameter);
        }
    
        public virtual ObjectResult<Nullable<double>> xuat_SinhVien_DiemTB_HocPhan(string masv, string mahocphan)
        {
            var masvParameter = masv != null ?
                new ObjectParameter("masv", masv) :
                new ObjectParameter("masv", typeof(string));
    
            var mahocphanParameter = mahocphan != null ?
                new ObjectParameter("mahocphan", mahocphan) :
                new ObjectParameter("mahocphan", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<double>>("xuat_SinhVien_DiemTB_HocPhan", masvParameter, mahocphanParameter);
        }
    
        public virtual ObjectResult<xuat_SinhVien_DiemTB_TaiKhoan_Result> xuat_SinhVien_DiemTB_TaiKhoan(string taikhoan)
        {
            var taikhoanParameter = taikhoan != null ?
                new ObjectParameter("taikhoan", taikhoan) :
                new ObjectParameter("taikhoan", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<xuat_SinhVien_DiemTB_TaiKhoan_Result>("xuat_SinhVien_DiemTB_TaiKhoan", taikhoanParameter);
        }
    
        public virtual ObjectResult<xuat_SinhVien_DSDiem_ki_TaiKhoan_Result> xuat_SinhVien_DSDiem_ki_TaiKhoan(string taikhoan, Nullable<int> ki)
        {
            var taikhoanParameter = taikhoan != null ?
                new ObjectParameter("taikhoan", taikhoan) :
                new ObjectParameter("taikhoan", typeof(string));
    
            var kiParameter = ki.HasValue ?
                new ObjectParameter("ki", ki) :
                new ObjectParameter("ki", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<xuat_SinhVien_DSDiem_ki_TaiKhoan_Result>("xuat_SinhVien_DSDiem_ki_TaiKhoan", taikhoanParameter, kiParameter);
        }
    
        public virtual ObjectResult<xuat_SinhVien_LopHocPhan_Result> xuat_SinhVien_LopHocPhan(string lophocphan)
        {
            var lophocphanParameter = lophocphan != null ?
                new ObjectParameter("lophocphan", lophocphan) :
                new ObjectParameter("lophocphan", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<xuat_SinhVien_LopHocPhan_Result>("xuat_SinhVien_LopHocPhan", lophocphanParameter);
        }
    
        public virtual ObjectResult<xuat_SinhVien_LopHocPhan_GiaoVien_Result> xuat_SinhVien_LopHocPhan_GiaoVien(string giaoVien)
        {
            var giaoVienParameter = giaoVien != null ?
                new ObjectParameter("GiaoVien", giaoVien) :
                new ObjectParameter("GiaoVien", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<xuat_SinhVien_LopHocPhan_GiaoVien_Result>("xuat_SinhVien_LopHocPhan_GiaoVien", giaoVienParameter);
        }
    
        public virtual ObjectResult<xuat_SinhVien_LopHocPhan_GiaoVien2_Result> xuat_SinhVien_LopHocPhan_GiaoVien2(string giaoVien, string lophocphan)
        {
            var giaoVienParameter = giaoVien != null ?
                new ObjectParameter("GiaoVien", giaoVien) :
                new ObjectParameter("GiaoVien", typeof(string));
    
            var lophocphanParameter = lophocphan != null ?
                new ObjectParameter("lophocphan", lophocphan) :
                new ObjectParameter("lophocphan", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<xuat_SinhVien_LopHocPhan_GiaoVien2_Result>("xuat_SinhVien_LopHocPhan_GiaoVien2", giaoVienParameter, lophocphanParameter);
        }
    
        public virtual ObjectResult<xuat_SinhVien_TaiKhoan_Result> xuat_SinhVien_TaiKhoan(string taikhoan)
        {
            var taikhoanParameter = taikhoan != null ?
                new ObjectParameter("taikhoan", taikhoan) :
                new ObjectParameter("taikhoan", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<xuat_SinhVien_TaiKhoan_Result>("xuat_SinhVien_TaiKhoan", taikhoanParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> xuat_SinhVien_TinChi(string masv)
        {
            var masvParameter = masv != null ?
                new ObjectParameter("masv", masv) :
                new ObjectParameter("masv", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("xuat_SinhVien_TinChi", masvParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> xuat_SinhVien_TinChiTL(string masv)
        {
            var masvParameter = masv != null ?
                new ObjectParameter("masv", masv) :
                new ObjectParameter("masv", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("xuat_SinhVien_TinChiTL", masvParameter);
        }
    
        public virtual ObjectResult<xuat_TaiKhoan_Result> xuat_TaiKhoan()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<xuat_TaiKhoan_Result>("xuat_TaiKhoan");
        }
    
        public virtual ObjectResult<string> xuat_TenSinhVien_TaiKhoan(string taikhoan)
        {
            var taikhoanParameter = taikhoan != null ?
                new ObjectParameter("taikhoan", taikhoan) :
                new ObjectParameter("taikhoan", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("xuat_TenSinhVien_TaiKhoan", taikhoanParameter);
        }
    
        public virtual ObjectResult<xuat_LopHP_GiaoVien_Result> xuat_LopHP_GiaoVien(string magiaovien)
        {
            var magiaovienParameter = magiaovien != null ?
                new ObjectParameter("magiaovien", magiaovien) :
                new ObjectParameter("magiaovien", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<xuat_LopHP_GiaoVien_Result>("xuat_LopHP_GiaoVien", magiaovienParameter);
        }
    
        public virtual ObjectResult<xuat_LopHP_Result> xuat_LopHP(string mahp)
        {
            var mahpParameter = mahp != null ?
                new ObjectParameter("mahp", mahp) :
                new ObjectParameter("mahp", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<xuat_LopHP_Result>("xuat_LopHP", mahpParameter);
        }
    
        public virtual ObjectResult<xuat_SinhVien_Diem_CaKi_LopHocPhan_Result> xuat_SinhVien_Diem_CaKi_LopHocPhan(string masv, string lop, Nullable<int> ki)
        {
            var masvParameter = masv != null ?
                new ObjectParameter("masv", masv) :
                new ObjectParameter("masv", typeof(string));
    
            var lopParameter = lop != null ?
                new ObjectParameter("lop", lop) :
                new ObjectParameter("lop", typeof(string));
    
            var kiParameter = ki.HasValue ?
                new ObjectParameter("ki", ki) :
                new ObjectParameter("ki", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<xuat_SinhVien_Diem_CaKi_LopHocPhan_Result>("xuat_SinhVien_Diem_CaKi_LopHocPhan", masvParameter, lopParameter, kiParameter);
        }
    
        public virtual int new_TaiKhoan(string tdn, string mk, Nullable<System.DateTime> ngaylap, Nullable<System.DateTime> han, Nullable<int> quyen)
        {
            var tdnParameter = tdn != null ?
                new ObjectParameter("tdn", tdn) :
                new ObjectParameter("tdn", typeof(string));
    
            var mkParameter = mk != null ?
                new ObjectParameter("mk", mk) :
                new ObjectParameter("mk", typeof(string));
    
            var ngaylapParameter = ngaylap.HasValue ?
                new ObjectParameter("ngaylap", ngaylap) :
                new ObjectParameter("ngaylap", typeof(System.DateTime));
    
            var hanParameter = han.HasValue ?
                new ObjectParameter("han", han) :
                new ObjectParameter("han", typeof(System.DateTime));
    
            var quyenParameter = quyen.HasValue ?
                new ObjectParameter("quyen", quyen) :
                new ObjectParameter("quyen", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("new_TaiKhoan", tdnParameter, mkParameter, ngaylapParameter, hanParameter, quyenParameter);
        }
    
        public virtual int sua_TaiKhoan(string tdn, string mk, Nullable<System.DateTime> ngaylap, Nullable<System.DateTime> han, Nullable<int> quyen)
        {
            var tdnParameter = tdn != null ?
                new ObjectParameter("tdn", tdn) :
                new ObjectParameter("tdn", typeof(string));
    
            var mkParameter = mk != null ?
                new ObjectParameter("mk", mk) :
                new ObjectParameter("mk", typeof(string));
    
            var ngaylapParameter = ngaylap.HasValue ?
                new ObjectParameter("ngaylap", ngaylap) :
                new ObjectParameter("ngaylap", typeof(System.DateTime));
    
            var hanParameter = han.HasValue ?
                new ObjectParameter("han", han) :
                new ObjectParameter("han", typeof(System.DateTime));
    
            var quyenParameter = quyen.HasValue ?
                new ObjectParameter("quyen", quyen) :
                new ObjectParameter("quyen", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sua_TaiKhoan", tdnParameter, mkParameter, ngaylapParameter, hanParameter, quyenParameter);
        }
    
        public virtual ObjectResult<tk_TaiKhoan_Result> tk_TaiKhoan(string search)
        {
            var searchParameter = search != null ?
                new ObjectParameter("search", search) :
                new ObjectParameter("search", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<tk_TaiKhoan_Result>("tk_TaiKhoan", searchParameter);
        }
    
        public virtual int xoa_TaiKhoan(string tdn)
        {
            var tdnParameter = tdn != null ?
                new ObjectParameter("tdn", tdn) :
                new ObjectParameter("tdn", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("xoa_TaiKhoan", tdnParameter);
        }
    
        public virtual ObjectResult<xuat_Lop_Result> xuat_Lop(string ma)
        {
            var maParameter = ma != null ?
                new ObjectParameter("ma", ma) :
                new ObjectParameter("ma", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<xuat_Lop_Result>("xuat_Lop", maParameter);
        }
    
        public virtual ObjectResult<xuat_SinhVien_Lop_Result> xuat_SinhVien_Lop(string lophocphan)
        {
            var lophocphanParameter = lophocphan != null ?
                new ObjectParameter("lophocphan", lophocphan) :
                new ObjectParameter("lophocphan", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<xuat_SinhVien_Lop_Result>("xuat_SinhVien_Lop", lophocphanParameter);
        }
    }
}