using System.ComponentModel.DataAnnotations;

namespace cms.Data{

    public class CustomUser{
        ///
        [Key]
        public int Id{get;set;}

        [Required]
        public string? UserName{get;set;}
        [Required]
        public string? UserPassword{get;set;}
        public string? UserNickName{get;set;}
        ///
    }
}