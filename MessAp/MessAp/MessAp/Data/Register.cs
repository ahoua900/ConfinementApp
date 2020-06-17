using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MessAp.Data
{
   public class Register
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string User { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
