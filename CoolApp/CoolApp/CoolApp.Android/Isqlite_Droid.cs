using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using System.IO;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CoolApp.Droid;
using Xamarin.Forms;

[assembly:Dependency(typeof(Isqlite_Droid))]
namespace CoolApp.Droid
{
    class Isqlite_Droid : Isqlite
    {
        public SQLiteConnection GetConnection()
        {
            var dbname = "SOCIALDB";
            var dbpath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
            var path = Path.Combine(dbpath, dbname);
            var conn = new SQLiteConnection(path);
            return conn;
        }
    }
}