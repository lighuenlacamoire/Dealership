using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Models.DTO
{
    public class AssetDto
    {
        public string Id { get; set; }

        [MinLength(50, ErrorMessage = "The name must have minimum length of 4 characters.")]
        [Required(ErrorMessage = "The name is mandatory.")]
        public string Name { get; set; }

        [StringLength(50, ErrorMessage = "The description have maximum length of 50 characters.")]
        [Required(ErrorMessage = "The description is mandatory.")]
        public string Description { get; set; }

    }
}
