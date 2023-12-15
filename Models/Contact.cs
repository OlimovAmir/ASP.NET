using System.ComponentModel.DataAnnotations;

namespace ASP.NET.Models
{
    public class Contact
    {
        [Display(Name = "Введите Имя")]
        [Required(ErrorMessage = "Заполните поля")]
        public string Name { get; set; }

        [Display(Name = "Введите Фамилию")]
        [Required(ErrorMessage = "Заполните поля")]
        public string SureName { get; set; }

        [Display(Name = "Введите возраст")]
        [Required(ErrorMessage = "Заполните поля")]
        public int Age { get; set; }

        [Display(Name = "Введите почту")]
        [Required(ErrorMessage = "Заполните поля")]
        public string Email { get; set;}

        [Display(Name = "Введите сообщение")]
        [Required(ErrorMessage = "Заполните поля")]
        [StringLength(30, ErrorMessage = "Текст менее 30 символов")]
        public string Message { get; set;}
    }
}
