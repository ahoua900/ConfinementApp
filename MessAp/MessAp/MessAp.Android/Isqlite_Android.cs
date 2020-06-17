using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.IO;
using Xamarin.Forms;
using MessAp.Droid;

[assembly: Dependency(typeof(Isqlite_Android))]
namespace MessAp.Droid
{
   public class Isqlite_Android : Isqlite
    {
        public SQLiteConnection GetConnection()
        {
            var dbName = "MyDbLive";
            var dbPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
            var path = Path.Combine(dbPath, dbName);
            var conn = new SQLiteConnection(path);
            return conn;
        }
        
    }
}