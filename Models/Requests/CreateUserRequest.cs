using System;
using System.ComponentModel.DataAnnotations;

namespace TodoMvc
{
    public class CreateUserRequest
    {
        [Required]
        [StringLength(25, ErrorMessage = "cannot exceed [25] characters.")]
        public string Firstname { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "cannot exceed [25] characters.")]
        public string Lastname { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "cannot exceed [50] characters.")]
        public string Username { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "cannot exceed [50] characters.")]
        public string Email { get; set; }

        [StringLength(10, ErrorMessage = "cannot exceed [10] characters.")]
        public string Phone { get; set; }
    }
}