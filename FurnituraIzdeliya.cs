//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SheiApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class FurnituraIzdeliya
    {
        public string ArticulFurnitury { get; set; }
        public string ArticulIzdeliya { get; set; }
        public string Razmechshenie { get; set; }
        public Nullable<int> Shirina { get; set; }
        public Nullable<int> Dlina { get; set; }
        public Nullable<int> Povorot { get; set; }
        public int Kolichectvo { get; set; }
    
        public virtual Furnitura Furnitura { get; set; }
        public virtual Tkan Tkan { get; set; }
    }
}