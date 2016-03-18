//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class tblPrimaryCaregiverdata
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPrimaryCaregiverdata()
        {
            this.tblAddresses = new HashSet<tblAddress>();
            this.tblCommunications = new HashSet<tblCommunication>();
            this.tblEmails = new HashSet<tblEmail>();
            this.tblInquiryReferralStatus = new HashSet<tblInquiryReferralStatu>();
            this.tblPhones = new HashSet<tblPhone>();
            this.tblRelatedCaregivers = new HashSet<tblRelatedCaregiver>();
            this.tblTrainingHistoryMains = new HashSet<tblTrainingHistoryMain>();
        }
    
        public int CareGiverID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<int> BestReached { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> Gender { get; set; }
        public Nullable<int> Certifier { get; set; }
        public Nullable<int> Agency { get; set; }
        public Nullable<int> Neighborhood { get; set; }
        public string Notes { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<int> CreateBy { get; set; }
        public Nullable<System.DateTime> LastUpdate { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<bool> PhysicianRel { get; set; }
        public Nullable<bool> English { get; set; }
        public Nullable<bool> InternetAccess { get; set; }
        public Nullable<bool> LivesNear { get; set; }
        public Nullable<bool> Recovery { get; set; }
        public Nullable<bool> DHSRelease { get; set; }
        public Nullable<bool> ExtraRoom { get; set; }
        public Nullable<bool> Income { get; set; }
        public Nullable<bool> Over25 { get; set; }
        public Nullable<bool> Roommate { get; set; }
        public Nullable<bool> DUI { get; set; }
        public Nullable<bool> Transportation { get; set; }
        public Nullable<bool> ParentChild { get; set; }
        public string ChildrenHome { get; set; }
        public string HeardAbout { get; set; }
        public Nullable<bool> Spanish { get; set; }
        public Nullable<bool> Respite { get; set; }
        public Nullable<int> ChildrenInHome { get; set; }
        public Nullable<bool> Volunteer { get; set; }
        public Nullable<bool> Donor { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAddress> tblAddresses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCommunication> tblCommunications { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEmail> tblEmails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblInquiryReferralStatu> tblInquiryReferralStatus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPhone> tblPhones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRelatedCaregiver> tblRelatedCaregivers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTrainingHistoryMain> tblTrainingHistoryMains { get; set; }
    }
}
