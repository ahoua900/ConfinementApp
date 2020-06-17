using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace NaN
{
    public interface Isqlite
    {
         SQLiteConnection GetConnection();
    }
}
