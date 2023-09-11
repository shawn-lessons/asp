using System;
using System.ComponentModel.DataAnnotations;
namespace AspNetD202.Models
{
    public class Course
    {
        public Guid Id { get; set; }
        public string CourseId { get; set; }

        [Required]
        public string Title { get; set; }


    }
}
