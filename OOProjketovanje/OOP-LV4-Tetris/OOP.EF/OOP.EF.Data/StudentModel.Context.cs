﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OOP.EF.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OOPEntities : DbContext
    {
        public OOPEntities()
            : base("name=OOPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ispit> ispits { get; set; }
        public virtual DbSet<student> students { get; set; }
        public virtual DbSet<student_ispit> student_ispit { get; set; }
        public virtual DbSet<student_telefon> student_telefon { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
