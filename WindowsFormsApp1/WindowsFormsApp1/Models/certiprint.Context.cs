﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class certiprintContainer : DbContext
    {
        public certiprintContainer()
            : base("name=certiprintContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<login> logins { get; set; }
        public DbSet<admin> admins { get; set; }
        public DbSet<facilitator> facilitators { get; set; }
        public DbSet<certificate> certificates { get; set; }
        public DbSet<student> students { get; set; }
    }
}
