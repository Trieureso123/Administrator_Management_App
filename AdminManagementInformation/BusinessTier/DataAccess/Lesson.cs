using System;
using System.Collections.Generic;

#nullable disable

namespace Library.DataAccess
{
    public partial class Lesson
    {
        public int IdLesson { get; set; }
        public int IdCategory { get; set; }
        public string NameLesson { get; set; }
        public string VideoUrl { get; set; }
    }
}
