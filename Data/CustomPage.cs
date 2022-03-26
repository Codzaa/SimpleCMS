using System;
using System.ComponentModel.DataAnnotations;

namespace cms.Data
{
    
    public class CustomPage
    {
        [Key]
        public int Id { get; set; }
        public int OwnerId{get;set;}
        public int SiteId{get;set;}
        [Required]
        public string? PageName { get; set; }
        [Required]
        public string? PageHeading { get; set; }
        public string? Body { get; set; }

        
    }
}
