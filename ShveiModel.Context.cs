﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ShveiEntities : DbContext
    {
        public ShveiEntities()
            : base("name=ShveiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cvet> Cvets { get; set; }
        public virtual DbSet<Furnitura> Furnituras { get; set; }
        public virtual DbSet<FurnituraIzdeliya> FurnituraIzdeliyas { get; set; }
        public virtual DbSet<Izdelie> Izdelies { get; set; }
        public virtual DbSet<MaterialSostav> MaterialSostavs { get; set; }
        public virtual DbSet<Polzovatel> Polzovatels { get; set; }
        public virtual DbSet<Risunok> Risunoks { get; set; }
        public virtual DbSet<Rulon> Rulons { get; set; }
        public virtual DbSet<SkladFurnitury> SkladFurnituries { get; set; }
        public virtual DbSet<SkladTkani> SkladTkanis { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TipFurnitury> TipFurnituries { get; set; }
        public virtual DbSet<Tkan> Tkans { get; set; }
        public virtual DbSet<Zakaz> Zakazs { get; set; }
        public virtual DbSet<ZakazannieIzdeliya> ZakazannieIzdeliyas { get; set; }
    }
}
