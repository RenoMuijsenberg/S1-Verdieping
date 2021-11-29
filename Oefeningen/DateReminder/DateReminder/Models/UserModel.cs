using System.ComponentModel.DataAnnotations;

namespace DateReminder.Models
{
    public class UserModel
    {
        //Id of user
        [Key]
        public int Id { get; set; }

        //Name of user
        [Required(ErrorMessage = "Username is required")]
        public string UserName { get; set; }

        //Password of user
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}
