using System.ComponentModel.DataAnnotations;

namespace MyWebApiApp.Models
{
    public class LoaiVM
    {
        [Key]
        public int MaLoai { get; set; }
        public string TenLoai { get; set; }
    }
}
 