using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PoPUpModal.Models
{
    public class Blog
    {

        public int BlogId { get; set; }

        [Display(Name = "Blog Name")]
        [Required(ErrorMessage = "Blog Name is Required.")]
        public string Name { get; set; }

        [Display(Name = "Category Name")]
        [Required(ErrorMessage = "Category Name is Required.")]
        public string CategoryName { get; set; }


    }
}