//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StoreManagement.Models.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class account
    {
        public string ID { get; set; }
        public string EMPLOYEEID { get; set; }
        public string ACC { get; set; }
        public string PASS { get; set; }
        public Nullable<bool> ROLES { get; set; }
        public Nullable<System.DateTime> CREATED_AT { get; set; }
        public Nullable<System.DateTime> UPDATED_AT { get; set; }
    
        public virtual employee employee { get; set; }
    }
}
