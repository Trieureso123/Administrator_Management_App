using System;
using System.Collections.Generic;

#nullable disable

namespace Library.DataAccess
{
    public partial class Feedback
    {
        public int IdFeedback { get; set; }
        public int? IdLesson { get; set; }
        public string LessonFeedback { get; set; }
        public string PhoneNumber { get; set; }
        public int? Rating { get; set; }

        public virtual Lesson IdLessonNavigation { get; set; }
    }
}
