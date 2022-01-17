using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InAndOut.Models
{
    public class ExpensesModel
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Name of an expense")]
        [Required]
        public string ExpenseName { get; set; }
        [Display(Name = " Amount of an expense")]
        [Required]
        [Range(1,int.MaxValue,ErrorMessage ="Amount must be grater than 0")]
        public int ExpenseAmount { get; set; }
        [Display(Name = "Expense category")]
        public int ExpensesCategoriesId { get; set; }
        [ForeignKey("ExpensesCategoriesId")]
        public virtual ExpensesCategoriesModel ExpensesCategories { get; set; }
    }
}
