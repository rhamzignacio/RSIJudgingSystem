﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RSI_Judging_System
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RSIJudgingSystemEntities : DbContext
    {
        public RSIJudgingSystemEntities()
            : base("name=RSIJudgingSystemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ContestantProfile> ContestantProfile { get; set; }
        public virtual DbSet<JudgeProfile> JudgeProfile { get; set; }
        public virtual DbSet<Top10Judge1> Top10Judge1 { get; set; }
        public virtual DbSet<Top10Judge2> Top10Judge2 { get; set; }
        public virtual DbSet<Top10Judge3> Top10Judge3 { get; set; }
        public virtual DbSet<Top10Judge4> Top10Judge4 { get; set; }
        public virtual DbSet<Top10Judge5> Top10Judge5 { get; set; }
        public virtual DbSet<Top10Judge6> Top10Judge6 { get; set; }
        public virtual DbSet<Top10Judge7> Top10Judge7 { get; set; }
        public virtual DbSet<Top5Judge1> Top5Judge1 { get; set; }
        public virtual DbSet<Top5Judge2> Top5Judge2 { get; set; }
        public virtual DbSet<Top5Judge3> Top5Judge3 { get; set; }
        public virtual DbSet<Top5Judge4> Top5Judge4 { get; set; }
        public virtual DbSet<Top5Judge5> Top5Judge5 { get; set; }
        public virtual DbSet<Top5Judge6> Top5Judge6 { get; set; }
        public virtual DbSet<Top5Judge7> Top5Judge7 { get; set; }
    }
}
