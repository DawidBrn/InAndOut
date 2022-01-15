using System.ComponentModel.DataAnnotations;

namespace InAndOut.Models
{
    public class ExpensesCategoriesModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CategoryName { get; set; }
        
        
    }
}
