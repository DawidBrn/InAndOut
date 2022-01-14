using System.ComponentModel.DataAnnotations;

namespace InAndOut.Models
{
    public class ExpensesModel
    {
        [Key]
        public int Id { get; set; }
        public string ExpenseName { get; set; }
        public int ExpenseAmount { get; set; }
    }
}
