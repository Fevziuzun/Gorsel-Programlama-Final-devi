//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GorselProje
{
    using System;
    using System.Collections.Generic;
    
    public partial class ogrenciDers
    {
        public short ogrenciDersID { get; set; }
        public Nullable<short> ogrenciDers2ID { get; set; }
        public Nullable<short> ogrenciDersOgrenciID { get; set; }
    
        public virtual ders ders { get; set; }
        public virtual ogrenci ogrenci { get; set; }
    }
}