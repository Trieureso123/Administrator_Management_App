using System;
using System.Collections.Generic;

#nullable disable

namespace Library.DataAccess
{
    public partial class Question
    {
        public int IdQuestion { get; set; }
        public string Question1 { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsRead { get; set; }
    }
}
