//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcBloggy.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tag
    {
        public Tag()
        {
            this.TagsForBlogPosts = new HashSet<TagsForBlogPost>();
            this.TagsForDynamicPages = new HashSet<TagsForDynamicPage>();
        }
    
        public int Key { get; set; }
        public int LanguageKey { get; set; }
        public System.Guid TagGuid { get; set; }
        public string TagName { get; set; }
        public string CreationIp { get; set; }
        public System.DateTimeOffset CreatedOn { get; set; }
    
        public virtual Language Language { get; set; }
        public virtual ICollection<TagsForBlogPost> TagsForBlogPosts { get; set; }
        public virtual ICollection<TagsForDynamicPage> TagsForDynamicPages { get; set; }
    }
}
