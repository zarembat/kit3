﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Insurance_Company.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class InsuranceCompanyEntities : DbContext
    {
        public InsuranceCompanyEntities()
            : base("name=InsuranceCompanyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AdressSet> AdressSet { get; set; }
        public virtual DbSet<CarSet> CarSet { get; set; }
        public virtual DbSet<ClientSet> ClientSet { get; set; }
        public virtual DbSet<EmployeeSet> EmployeeSet { get; set; }
        public virtual DbSet<HouseSet> HouseSet { get; set; }
        public virtual DbSet<PolicySet> PolicySet { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
