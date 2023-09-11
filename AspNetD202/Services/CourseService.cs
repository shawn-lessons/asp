using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetD202.Data;
using AspNetD202.Models;
using Microsoft.EntityFrameworkCore;
namespace AspNetD202.Services
{
    public class CourseService : ICourseService
    {
        private readonly ApplicationDbContext _context;
        public CourseService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddCourseAsync(Course course)
        {
            course.Id = Guid.NewGuid();
            _context.Courses.Add(course);
            var saveResult = await _context.SaveChangesAsync();
            return saveResult == 1;
        }

        public async Task<Course[]> GetCoursesAsync()
        {
            return await _context.Courses
            .Where(x => x == x)
            .ToArrayAsync();
        }
    }
}
