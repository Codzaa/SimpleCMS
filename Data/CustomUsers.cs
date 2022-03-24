using System.ComponentModel.DataAnnotations;

namespace cms.Data{

    public class CustomUser{
        ///
        [Key]
        public int Id{get;set;}
        public string? UserName{get;set;}
        public string? UserPassword{get;set;}
        public string? UserNickName{get;set;}
        ///
    }
}