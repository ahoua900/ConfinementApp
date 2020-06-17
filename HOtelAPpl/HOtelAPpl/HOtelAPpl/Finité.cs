using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace HOtelAPpl
{
    public class Finité
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int Chambre { get; set; }
        public string Types { get; set; }
        public string Arrivée { get; set; }
        public string Entrée { get; set; }
        public string Sortie { get; set; }
    }
}
