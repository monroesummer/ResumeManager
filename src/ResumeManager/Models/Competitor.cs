using System.ComponentModel.DataAnnotations;

namespace ResumeManager.Models
{
    public class Competitor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить \"Компания\"")]
        public int CompanyId { get; set; }
        public Company Company { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить \"Имя\"")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить \"Фамилия\"")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить \"Отчество\"")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить \"День Рождения\"")]
        public string Birthdate { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить \"Дата Заполнения\"")]
        public string FillingDate { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить \"Номер Телефона\"")]
        [Phone(ErrorMessage = "Введите корректный номер телефона")]
        public string Phone { get; set; }

        [EmailAddress(ErrorMessage = "Введите корректный E-mail")]
        [Required(ErrorMessage = "Необходимо заполнить \"E-Mail\"")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить \"Предпочитаемая Зарплата\"")]
        public string PreferSalary { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить \"Образование\"")]
        public string Education { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить \"Знание OS\"")]
        public string OS { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить \"Знание СУБД\"")]
        public string Database { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить \"Языки Программирования\"")]
        public string PL { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить \"Сетевые Технологии\"")]
        public string Network { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить \"CASE - Технологии\"")]
        public string CASE { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить \"Работа в Команде\"")]
        public string TeamDev { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить \"Опыт в Разработке\"")]
        public string Experience { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить \"Хобби\"")]
        public string Hobby { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить \"Карьера\"")]
        public string Career { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить \"Деньги\"")]
        public string Money { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить \"Близость к Дому\"")]
        public string Home { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить \"Престиж Компании\"")]
        public string Prestige { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить \"Языковая Практика\"")]
        public string Language { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить \"Стабильность Компании\"")]
        public string Stability { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить \"Приобретение Опыта\"")]
        public string Knowledge { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить \"Интенсивность Работы\"")]
        public string Intensity { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить \"Сложность Поставленных Задач\"")]
        public string Complexity { get; set; }

        public string Mark { get; set; }
    }
}
