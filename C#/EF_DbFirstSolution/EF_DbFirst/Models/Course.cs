using System;
using System.Collections.Generic;

namespace EF_DbFirst.Models;

public partial class Course
{
    public int CourseId { get; set; }

    public string? Name { get; set; }
}
