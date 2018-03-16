using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Droid
{
    interface ISQLite
    {
        string GetDatabasePath(string filename);
    }
}
