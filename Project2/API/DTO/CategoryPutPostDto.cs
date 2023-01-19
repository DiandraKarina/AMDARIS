using System.ComponentModel.DataAnnotations;

namespace API.DTO
{
    public class CategoryPutPostDto
    {
        [Required]
        public string CategoryName { get; set; }
    }
}
