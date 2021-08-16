using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Category
    {
        [Key]
        public int Id{ get; set; }
        [Required]
        public string  Name{ get; set; }
        [Required]
        [Range(1,int.MaxValue,ErrorMessage ="0 dan büyük olmalı.")]
        public int DisplayOrder{ get; set; }
    }
}
