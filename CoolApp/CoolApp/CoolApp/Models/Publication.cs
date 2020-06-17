using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace CoolApp.Models
{
    public class Publication
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public string ImageUrl { get; set; }
    }
}
