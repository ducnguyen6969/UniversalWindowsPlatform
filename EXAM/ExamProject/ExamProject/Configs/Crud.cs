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

        public bool CreateContact(string name, string phone, string errName, string errPhone)
        {
            var conn = new SQLiteConnection("Contact.db");
            try
            {
                var stmt = "INSERT INTO Contact(Name, PhoneNumber)" +
                    "VALUES (?,?)";
                using (var spmt = conn.Prepare(stmt))
                {
                    if (name == null)
                    {
                        errName = "*Name is required !";
                        return false;
                    }
                    else
                    {
                        errName = "";
                        spmt.Bind(1, name.ToString());
                    }

                    if (phone == null)
                    {
                        errPhone = "*Phone is required !";
                        return false;
                    }
                    else
                    {
                        errPhone = "";
                        spmt.Bind(2, phone.ToString());
                    }

                    spmt.Step();
                };
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
