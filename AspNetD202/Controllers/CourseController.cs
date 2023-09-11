using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using AspNetD202.Models;
using AspNetD202.Services;

namespace AspNetD202.Controllers;

[Authorize]
public class CourseController : Controller
{

    private readonly ICourseService _courseService;

    public CourseController(ICourseService courseService)
    {
        _courseService = courseService;
    }

    public async Task<IActionResult> Index()
    {

        var courses = await _courseService.GetCoursesAsync();

        var model = new CourseViewModel()
        {
            Courses = courses
        };

     

        return View(model);
    }

    [ValidateAntiForgeryToken]
    public async Task<IActionResult> AddCourse(Course newCourse)
    {
        if (!ModelState.IsValid)
        {
            Console.WriteLine("what?");
            return RedirectToAction("Index");
        }
        var successful = await _courseService.AddCourseAsync(newCourse);
        if (!successful)
        {
            return BadRequest("Could not add item.");
        }
        return RedirectToAction("Index");
    }





}