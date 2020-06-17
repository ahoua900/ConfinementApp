using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace OpenData.Models
{
   public class Organisatio
    {
        public string id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public string description { get; set; }
        public string logo { get; set; }
        public string website { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string created_at { get; set; }
        public string last_modifie { get; set; }
    }
}
