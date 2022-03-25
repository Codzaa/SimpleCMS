
using System.ComponentModel.DataAnnotations;

namespace cms.Data
{
    public class CustomSite{

        [Key]
        public int Id{get;set;}
        public int OwnerId{get;set;}
        public string? SiteUrl{get;set;}
        [Required]
        public string? SiteName{get;set;}
        [Required]
        public string? SiteDescription{get;set;}
        
    }
}