using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace HOtelAPpl
{
   public  class Sejournée
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Entrée { get; set; }
        public string Sortie { get; set; }
        public int Chambre { get; set; }
        public int piece { get; set; }
    }

}
