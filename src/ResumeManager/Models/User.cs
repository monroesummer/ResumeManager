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

        [Required(ErrorMessage = "Необходимо заполнить \"Имя\"")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить \"Фамилия\"")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить \"Номер Телефона\"")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить \"Компания\"")]
        public string Company { get; set; }
    }
}
