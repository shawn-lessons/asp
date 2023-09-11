using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetD202.Models;

namespace AspNetD202.Services
{

    public class DummyCourseService : ICourseService
    {
        public Task<bool> AddCourseAsync(Course course)
        {
            throw new NotImplementedException();
        }

        public Task<Course[]> GetCoursesAsync()
        {
            var course1 = new Course
            {
                Title = "Inf Sys Fundamentals",
                CourseId = "I101"
            };
            var course2 = new Course
            {
                Title = "Programming",
                CourseId = "D101"
            };
            return Task.FromResult(new[] { course1, course2 });
        }
    }


}