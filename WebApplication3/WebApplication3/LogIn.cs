//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication3
{
    using System;
    using System.Collections.Generic;
    
    public partial class LogIn
    {
        public int LogID { get; set; }
        public string Password { get; set; }
        public Nullable<int> fk_UserNamesID { get; set; }
    
        public virtual UserName UserName { get; set; }
    }
}
