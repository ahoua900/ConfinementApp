using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace CoolApp
{
    public interface Isqlite
    {
        SQLiteConnection GetConnection();
    }
}
