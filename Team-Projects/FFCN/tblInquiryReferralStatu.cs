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
    
    public partial class tblInquiryReferralStatu
    {
        public Nullable<int> CareGiverID { get; set; }
        public Nullable<bool> InitialInquiry1 { get; set; }
        public Nullable<System.DateTime> DateInitialInquiry { get; set; }
        public string StaffInitialInquiry { get; set; }
        public Nullable<bool> DidntPass2 { get; set; }
        public Nullable<System.DateTime> DateDidntPass { get; set; }
        public string StaffDidntPass { get; set; }
        public Nullable<bool> LookingJob3 { get; set; }
        public Nullable<System.DateTime> DateLookingJob { get; set; }
        public string StaffLookingJob { get; set; }
        public Nullable<bool> OutOfState4 { get; set; }
        public Nullable<System.DateTime> DateOutOfStat { get; set; }
        public string StaffOutOfStat { get; set; }
        public Nullable<bool> Inactive5 { get; set; }
        public Nullable<System.DateTime> DateInactive { get; set; }
        public string StaffInactive { get; set; }
        public Nullable<bool> Active6 { get; set; }
        public Nullable<System.DateTime> DateActive { get; set; }
        public string StaffActive { get; set; }
        public Nullable<bool> AppReceived7 { get; set; }
        public Nullable<System.DateTime> DateAppReceived { get; set; }
        public string StaffAppReceived { get; set; }
        public Nullable<bool> AppProgram8 { get; set; }
        public Nullable<System.DateTime> DateAppProgram { get; set; }
        public string StaffAppProgram { get; set; }
        public Nullable<bool> AppReferrdProg9 { get; set; }
        public Nullable<System.DateTime> DateAppReferredProg { get; set; }
        public string StaffAppReferredProg { get; set; }
        public Nullable<bool> HomeCert10 { get; set; }
        public Nullable<System.DateTime> DateHomeCert1 { get; set; }
        public string StaffHomeCert { get; set; }
        public Nullable<bool> HomeClosed11 { get; set; }
        public Nullable<System.DateTime> DateHomeClosed { get; set; }
        public string StaffHomeClosed { get; set; }
        public Nullable<bool> AppOnHold12 { get; set; }
        public Nullable<System.DateTime> DateAppOnHold { get; set; }
        public string StaffAppOnHold { get; set; }
        public Nullable<bool> AppReturned13 { get; set; }
        public Nullable<System.DateTime> DateAppReturned { get; set; }
        public string StaffAppReturned { get; set; }
        public Nullable<bool> AppReferredtoAnother14 { get; set; }
        public Nullable<System.DateTime> DateAppReferredtoAnother { get; set; }
        public string StaffAppReferredtoAnother { get; set; }
        public Nullable<bool> AppRejectedProg15 { get; set; }
        public Nullable<System.DateTime> DateAppRejectedFFCN { get; set; }
        public string StaffAppRejectedFFCN { get; set; }
        public Nullable<bool> AppRejectedFFCN16 { get; set; }
        public Nullable<System.DateTime> DateAppRejectedProg { get; set; }
        public string StaffAppRejectedProg { get; set; }
        public string ReasonAppProgram { get; set; }
        public string ReasonAppReferredProg { get; set; }
        public string ReasonHomeCert { get; set; }
        public string ReasonHomeClosed { get; set; }
        public string ReasonAppOnHold { get; set; }
        public string ReasonAppReturned { get; set; }
        public string ReasonAppReferredAnother { get; set; }
        public string ReasonAppRejectedProg { get; set; }
        public int IDIRS { get; set; }
        public string ReasonAppRejectedFFCN { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
        public string ReasonInactive { get; set; }
    
        public virtual tblPrimaryCaregiverdata tblPrimaryCaregiverdata { get; set; }
    }
}
