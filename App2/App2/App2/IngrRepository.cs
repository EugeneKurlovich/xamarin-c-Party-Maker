using App2.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace App2
{
    public class IngrRepository
    {
        public SQLite.SQLiteConnection database;
        public IngrRepository(string filename)
        {
            string databasePath = DependencyService.Get<ISQLite>().GetDatabasePath(filename);
            database = new SQLite.SQLiteConnection(databasePath);
            database.CreateTable<Ingr>();
        }
        public IEnumerable<Ingr> GetItems()
        {
            return (from i in database.Table<Ingr>() select i).ToList();

        }

        public void geti(string n)
        {
            var t = (from i in database.Table<Ingr>() where i.Aname.Equals(n) select i).ToList();
            foreach(Ingr a in t)
            {
                Party.li.Add(a);
           }
        }

        public IEnumerable<Ingr> GetIngrs(string n)
        {
            return (from i in database.Table<Ingr>() where i.Name == n select i).ToList(); 
        }

        public Ingr GetItem(int id)
        {
            return database.Get<Ingr>(id);
        }

        public void DeleteIngrs()
        {
            database.DeleteAll<Ingr>();
        }

        public int DeleteItem(int id)
        {
            return database.Delete<Ingr>(id);
        }
        public int SaveItem(Ingr item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}

