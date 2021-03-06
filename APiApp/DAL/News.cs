//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class News
    {
        public News()
        {
            this.Comments = new HashSet<Comment>();
            this.Reactions = new HashSet<Reaction>();
        }
    
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Headline { get; set; }
        public string Details { get; set; }
        public System.DateTime Date { get; set; }
        public int AdminId { get; set; }
    
        public virtual Admin Admin { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Reaction> Reactions { get; set; }
    }
}
