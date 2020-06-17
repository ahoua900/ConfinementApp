using System;
using System.Collections.Generic;
using System.Text;

namespace OpenData.Models
{
    public class Ressource
    {
        public string dataset_id { get; set; }
        public string dataset_title { get; set; }
        public string dataset_slug { get; set; }
        public string organization { get; set; }
        public string organization_id { get; set; }
        public string resource_id { get; set; }
        public string resource_title { get; set; }
        public string resource_description { get; set; }
        public string resource_slug { get; set; }
        public string format { get; set; }
        public string filesize { get; set; }
        public string file { get; set; }
        public string remote_url { get; set; }
        public string created_at { get; set; }
        public string last_modifie { get; set; }
    }
}
