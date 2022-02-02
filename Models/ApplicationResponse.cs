using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4Jan24.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int ApplicationId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        [StringLength(20, ErrorMessage = "Must be less than 20 characters long")]
        public string Notes { get; set; }

        //Build a foreign key relationship
        [Required]
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
