using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using NaN.Droid;
using Xamarin.Forms;

[assembly:Dependency(typeof(Isqlite_Droid))]
namespace NaN.Droid
{
   public class Isqlite_Droid : Isqlite
    {
        public SQLiteConnection GetConnection()
        {
            var dbName = "MyDbName";
            var dbPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
            var path = Path.Combine(dbPath, dbName);
            var conn = new SQLiteConnection(path);
            return conn;

        }
    }
}