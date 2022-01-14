using System.ComponentModel.DataAnnotations;

namespace InAndOut.Models
{
    public class ItemModel
    {
        [Key]
        public int Id { get; set; }
        public string Borrower { get; set; }
        public string Lender { get; set; }
        [Display(Name = "Item name")]
        public string ItemName { get; set; }    

    }
}
