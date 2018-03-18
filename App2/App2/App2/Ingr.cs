using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App2
{
    [Table("Ingr")]
   public class Ingr
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { set; get; }

        public string Name { set; get; }
        public int V { set; get; }
        public string Aname { set; get; }

        public void setInfo(string n, int v, string an)
        {
            Name = n; V = v; Aname = an;
        }
    }
}
