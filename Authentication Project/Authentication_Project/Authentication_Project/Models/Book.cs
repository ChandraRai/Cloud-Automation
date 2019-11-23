using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication_Project.Models
{
    public class Book
    {
        public int BookId { get; set; }

        [Required(ErrorMessage = "Please enter book name.")]
        [Display(Name = "Book Items")]
        public string Items { get; set; }

        [Required(ErrorMessage = "Please enter ISBN.")]        
        public string ISBN { get; set; }

        [Required(ErrorMessage = "Please enter vendor.")]        
        public string Vendor { get; set; }

        [Required(ErrorMessage = "Please enter date.")]
        [DataType(DataType.Date)]
        public DateTime Received_Date { get; set; }       
    }
}
