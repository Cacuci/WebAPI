using System.ComponentModel.DataAnnotations;

namespace WebAPI.Controllers.Models
{
    public class Users
    {
        [Key]
        public int UserID { get; set; }
        
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }        
    }
}