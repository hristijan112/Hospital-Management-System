﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HMSbazaEntities : DbContext
    {
        public HMSbazaEntities()
            : base("name=HMSbazaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bolnica> Bolnica { get; set; }
        public virtual DbSet<ItniSlucai> ItniSlucai { get; set; }
        public virtual DbSet<Operacii> Operacii { get; set; }
        public virtual DbSet<Pacient> Pacient { get; set; }
        public virtual DbSet<Personal> Personal { get; set; }
    }
}
