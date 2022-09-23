using System;
using System.Collections.Generic;

#nullable disable

namespace Library.DataAccess
{
    public partial class Account
    {
        public int IdAccount { get; set; }
        public string NameAccount { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
