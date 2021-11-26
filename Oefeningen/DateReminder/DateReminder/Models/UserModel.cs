using System.ComponentModel.DataAnnotations;

namespace DateReminder.Models
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        
    }
}
