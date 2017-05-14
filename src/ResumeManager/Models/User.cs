using System.ComponentModel.DataAnnotations;

namespace ResumeManager.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить \"Логин\"")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить \"Пароль\"")]
        public string Password { get; set; }


    }
}
