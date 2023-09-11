using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetD202.Models;

namespace AspNetD202.Services
{
    public interface ICourseService
    {
        Task<Course[]> GetCoursesAsync();
        Task<bool> AddCourseAsync(Course course);

    }
}