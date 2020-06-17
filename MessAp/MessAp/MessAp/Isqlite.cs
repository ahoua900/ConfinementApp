using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MessAp
{
    public interface Isqlite
    {
        SQLiteConnection GetConnection();
    }
}
