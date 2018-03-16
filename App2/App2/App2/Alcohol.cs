using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;


namespace App2
{
    [Table("Alcohol")]
    public class Alcohol 
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

    }
}
