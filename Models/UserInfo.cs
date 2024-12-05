using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad Alanı Zorunlu")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Telefon Alanı Zorunlu")]
        public string? Phone { get; set; }
        [Required(ErrorMessage ="Hatalı Email")]
        [EmailAddress]
        public string? Email { get; set; }
        [Required(ErrorMessage ="Katılım Durumunu Seçiniz")]
        public bool WillAttend { get; set; }

    }
}