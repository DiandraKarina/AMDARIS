using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
   public class DataBase 
    {
        private DataBase() { }
        public List<User> users = new List<User>();

        private static DataBase dataBaseInstance = new DataBase();
        public static DataBase DataBaseInstance => dataBaseInstance;
    }
}
