﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdminCV.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ProiectCVEntities : DbContext
    {
        public ProiectCVEntities()
            : base("name=ProiectCVEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Degree> Degree { get; set; }
        public virtual DbSet<Education> Education { get; set; }
        public virtual DbSet<Institution> Institution { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<Language_level> Language_level { get; set; }
        public virtual DbSet<Level> Level { get; set; }
        public virtual DbSet<PersonalSkills> PersonalSkills { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<SkillCategory> SkillCategory { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<UserInfo> UserInfo { get; set; }
        public virtual DbSet<WorkExperience> WorkExperience { get; set; }
    }
}
