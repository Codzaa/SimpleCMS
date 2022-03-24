using System;
using System.ComponentModel.DataAnnotations;

namespace cms.Data
{
    
    public class CustomPage
    {
        [Key]
        public int Id { get; set; }

        public int SiteId{get;set;}
        public string? PageName { get; set; }
        public string? PageHeading { get; set; }
        public string? Body { get; set; }

        
    }
}
