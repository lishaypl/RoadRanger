﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DATAa
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class igroup190_prodEntities : DbContext
    {
        public igroup190_prodEntities()
            : base("name=igroup190_prodEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tblArea> tblAreas { get; set; }
        public virtual DbSet<tblAskForHelp> tblAskForHelps { get; set; }
        public virtual DbSet<tblComment> tblComments { get; set; }
        public virtual DbSet<tblConversation> tblConversations { get; set; }
        public virtual DbSet<tblCountry> tblCountries { get; set; }
        public virtual DbSet<tblEvent> tblEvents { get; set; }
        public virtual DbSet<tblLocation> tblLocations { get; set; }
        public virtual DbSet<tblStakeholder> tblStakeholders { get; set; }
        public virtual DbSet<tblTravelere> tblTraveleres { get; set; }
        public virtual DbSet<tblType> tblTypes { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }
    }
}