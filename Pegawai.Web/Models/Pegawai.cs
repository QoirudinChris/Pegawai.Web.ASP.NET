//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pegawai.Web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pegawai
    {
        public string NIP { get; set; }
        public int DivisiID { get; set; }
        public string Nama { get; set; }
        public string Alamat { get; set; }
        public Nullable<System.DateTime> TglLahir { get; set; }
    
        public virtual Divisi Divisi { get; set; }
    }
}
