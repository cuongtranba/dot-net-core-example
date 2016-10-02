using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ViewModels
{
    public class TaskEditViewModel
    {
        public int Id { get; set; }

        public bool IsAdding => Id == 0;
        [Required(ErrorMessage = "Please provide a description")]
        [StringLength(500, ErrorMessage = "The description cannot be longer than 500 characters")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public SelectList CategoryOptions { get; set; }
    }
}