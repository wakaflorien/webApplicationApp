using System.ComponentModel.DataAnnotations;

namespace WebApplicationApp.Models
{
    public class Home
    {
        [Required(ErrorMessage = "Fill in Registration number!!")]
        public int Regno { get; set; }
        [Required(ErrorMessage = "Fill in Your names!!")]
        public string Name { get; set; }
    }
}