using System.Collections.Generic;
using System.Linq;
using App2.Droid;
using SQLite;
using Xamarin.Forms;

namespace App2
{
   public class AlcoholRepository
    {
        SQLite.SQLiteConnection database;
        public AlcoholRepository(string filename)
        {
            string databasePath = DependencyService.Get<ISQLite>().GetDatabasePath(filename);
            database = new SQLite.SQLiteConnection(databasePath);
            database.CreateTable<Alcohol>();
        }
        public IEnumerable<Alcohol> GetItems()
        {
            return (from i in database.Table<Alcohol>() select i).ToList();

        }
        public Alcohol GetItem(int id)
        {
            return database.Get<Alcohol>(id);
        }
        public int DeleteItem(int id)
        {
            return database.Delete<Alcohol>(id);
        }
        public int SaveItem(Alcohol item)
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
