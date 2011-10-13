//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcBloggy.Data.DataAccess.SqlServer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Language
    {
        public Language()
        {
            this.BlogPosts = new HashSet<BlogPost>();
            this.DynamicPages = new HashSet<DynamicPage>();
            this.RestrictedPageNames = new HashSet<RestrictedPageName>();
        }
    
        public int LanguageID { get; set; }
        public System.Guid LanguageGUID { get; set; }
        public string DisplayName { get; set; }
        public string LanguageCulture { get; set; }
        public string LanguageCultureOne { get; set; }
        public Nullable<int> LanguageOrder { get; set; }
        public Nullable<bool> IsApproved { get; set; }
        public Nullable<System.DateTime> CreationOn { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
    
        public virtual ICollection<BlogPost> BlogPosts { get; set; }
        public virtual ICollection<DynamicPage> DynamicPages { get; set; }
        public virtual ICollection<RestrictedPageName> RestrictedPageNames { get; set; }
    }
}