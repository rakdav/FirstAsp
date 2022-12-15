using System.ComponentModel.DataAnnotations;

namespace FirstAsp.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Введите имя")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Введите email")]
        [EmailAddress]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Введите телефон")]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "Выберите вариант")]
        public bool? WillAttend { get; set; }
    }
}
