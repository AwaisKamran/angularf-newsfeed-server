//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AngularNewsFeed
{
    using System;
    using System.Collections.Generic;
    
    public partial class Post
    {
        public int postId { get; set; }
        public string postTitle { get; set; }
        public string postContent { get; set; }
        public Nullable<System.DateTime> postCreated { get; set; }
        public Nullable<int> postCategory { get; set; }
        public Nullable<bool> postApproved { get; set; }
        public Nullable<int> postedBy { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public string Tags { get; set; }
        public string MetaKeywords { get; set; }
        public string postSource { get; set; }
        public string OwnerOfSource { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
