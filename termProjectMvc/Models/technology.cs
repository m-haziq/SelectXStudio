//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace termProjectMvc.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class technology
    {
        public technology()
        {
            this.tests = new HashSet<test>();
            this.user1 = new HashSet<user1>();
            this.user11 = new HashSet<user1>();
            this.user12 = new HashSet<user1>();
        }
    
        public int Id { get; set; }
        public string name { get; set; }
    
        public virtual ICollection<test> tests { get; set; }
        public virtual ICollection<user1> user1 { get; set; }
        public virtual ICollection<user1> user11 { get; set; }
        public virtual ICollection<user1> user12 { get; set; }
    }
}