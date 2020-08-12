using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fuela_clients.Models
{
    public class BooksModel
    {
        [Display(Name = "Id")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Author is required.")]
        public string Author { get; set; }  
        
        [Required(ErrorMessage = "Description is required.")]
        public string Category { get; set; }  
        public string Language { get; set; }   
        public int TotalPages { get; set; } 
        public string Description { get; set; }

      
    }
}
