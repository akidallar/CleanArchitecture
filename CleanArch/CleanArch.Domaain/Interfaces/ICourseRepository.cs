using CleanArch.Domaain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domaain.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
        void Add(Course course);
    }
}
