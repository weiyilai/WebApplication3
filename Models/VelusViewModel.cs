using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebApplication3.Models
{
    public class VelusViewModel
    {
        [StringLength(100, ErrorMessage = "{0} 的長度至少必須為 {2} 個字元。", MinimumLength = 6)]
        public string Number { get; set; }

        public string? Convert36 { get; set; } = string.Empty;

        [StringLength(100, ErrorMessage = "{0} 的長度至少必須為 {2} 個字元。", MinimumLength = 6)]
        public string Alphanumeric { get; set; }

        public string? Convert10 { get; set; } = string.Empty;
    }
}
