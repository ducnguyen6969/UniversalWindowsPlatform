using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject.Configs
{
    class Crud
    {
          public static bool Create()
        {
            var conn = new SQLiteConnection("Contact.db");
            string sql = @"CREATE TABLE IF NOT EXISTS    
                           Contact (Id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
                           Name VARCHAR( 140 ),
                           PhoneNumber VARCHAR(150)) ;";
            using (var statement = conn.Prepare(sql))
            {
                statement.Step();
            }
            return true;
        }
    }
}
