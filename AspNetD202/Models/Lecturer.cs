using System;
using System.ComponentModel.DataAnnotations;
namespace AspNetD202.Models
{
    public class Lecturer
    {
        public Guid Id { get; set; }
        public string LecturerId { get; set; }

        [Required]
        public string Name { get; set; }


    }
}
