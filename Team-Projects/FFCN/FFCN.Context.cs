﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FFCNMaintenance
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FFCNEntities : DbContext
    {
        public FFCNEntities()
            : base("name=FFCNEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tblAddress> tblAddresses { get; set; }
        public virtual DbSet<tblCommunication> tblCommunications { get; set; }
        public virtual DbSet<tblEmail> tblEmails { get; set; }
        public virtual DbSet<tblInquiryReferralStatu> tblInquiryReferralStatus { get; set; }
        public virtual DbSet<tblPhone> tblPhones { get; set; }
        public virtual DbSet<tblPrimaryCaregiverdata> tblPrimaryCaregiverdatas { get; set; }
        public virtual DbSet<tblRelatedCaregiver> tblRelatedCaregivers { get; set; }
        public virtual DbSet<tblTrainingHistoryMain> tblTrainingHistoryMains { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }
        public virtual DbSet<tlkpAddressType> tlkpAddressTypes { get; set; }
        public virtual DbSet<tlkpAgency> tlkpAgencies { get; set; }
        public virtual DbSet<tlkpCommunicationType> tlkpCommunicationTypes { get; set; }
        public virtual DbSet<tlkpInactive> tlkpInactives { get; set; }
        public virtual DbSet<tlkpPhoneType> tlkpPhoneTypes { get; set; }
        public virtual DbSet<tlkpProgram> tlkpPrograms { get; set; }
        public virtual DbSet<tlkpRecruitmentCategory> tlkpRecruitmentCategories { get; set; }
        public virtual DbSet<tlkpRelationship> tlkpRelationships { get; set; }
    }
}
