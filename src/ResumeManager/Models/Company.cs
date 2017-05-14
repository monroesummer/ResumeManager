using System.ComponentModel.DataAnnotations;

namespace ResumeManager.Models
{
    public class Company
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить \"Название\"")]
        public string CompanyName { get; set; }


        [Required(ErrorMessage = "Необходимо заполнить \"Адрес\"")]
        public string Address { get; set; }


        [Required(ErrorMessage = "Необходимо заполнить \"Имя\"")]
        public string HRName { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить \"Фамилия\"")]
        public string HRLastName { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить \"Номер Телефона\"")]
        public string HRPhone { get; set; }


    }
}
