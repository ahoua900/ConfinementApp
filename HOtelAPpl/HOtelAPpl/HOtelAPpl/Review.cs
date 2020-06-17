using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace HOtelAPpl
{
   public class Review
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Gerant { get; set; }
        public int Chambre { get; set; }
        public string Type { get; set; }
        public string Arrivée { get; set; }
        public string Entrée { get; set; }
        public string Sortie { get; set; }

        public string ImageUrl { get; set; }
        public int piece { get; set; }
        

    }
}
