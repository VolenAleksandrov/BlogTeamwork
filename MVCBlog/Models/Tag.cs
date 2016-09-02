using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBlog.Models
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }
         
        [Required]
        public string Text { get; set; }
    }
}