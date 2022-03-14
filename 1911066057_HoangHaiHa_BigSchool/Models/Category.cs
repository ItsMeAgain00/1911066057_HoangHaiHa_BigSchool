using System.ComponentModel.DataAnnotations;

namespace _1911066057_HoangHaiHa_BigSchool.Models
{
    public class Category
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }   
    }
}