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
    
    public partial class user1
    {
        public user1()
        {
            this.scores = new HashSet<score>();
        }
    
        public int Id { get; set; }
        public string fname { get; set; }
        public string email { get; set; }
        public Nullable<int> degreeId { get; set; }
        public string contactno { get; set; }
        public Nullable<int> instituteId { get; set; }
        public Nullable<int> technology1 { get; set; }
        public Nullable<int> technology2 { get; set; }
        public Nullable<int> technology3 { get; set; }
        public string password { get; set; }
    
        public virtual degree degree { get; set; }
        public virtual institute institute { get; set; }
        public virtual ICollection<score> scores { get; set; }
        public virtual technology technology { get; set; }
        public virtual technology technology4 { get; set; }
        public virtual technology technology5 { get; set; }
    }
}