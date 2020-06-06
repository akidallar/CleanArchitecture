using CleanArch.Application.ViewModels;
using CleanArch.Domaain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.Interfaces
{
    public interface ICourseService
    {
        CourseViewModel GetCourses();
        void Create(CourseViewModel courseViewModel);
    }
} 
