using System;
using System.ComponentModel.DataAnnotations;

namespace m4.Models
{
    public class FormResponse
    {
        [Key]
        [Required]
        public int FormID { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; }
        public bool Edited { get; set; }
    }
}
