//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab01.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class KHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHHANG()
        {
            this.DONDATHANGs = new HashSet<DONDATHANG>();
        }
    
        public int MaKH { get; set; }
        public string HoTenKH { get; set; }
        public string DiaChiKH { get; set; }
        public string DienthoaiKH { get; set; }
        public string TenDN { get; set; }
        public string Matkhau { get; set; }
        public Nullable<System.DateTime> Ngaysinh { get; set; }
        public Nullable<bool> Gioitinh { get; set; }
        public string Email { get; set; }
        public Nullable<bool> Daduyet { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONDATHANG> DONDATHANGs { get; set; }
    }
}
