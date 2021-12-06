using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regoin_Champ.db
{
    public class DBInstance
    {
        static Labaratory_DBEntities1 connection;
        static object objectLock = new object();
        public static Labaratory_DBEntities1 Get()
        {
            lock (objectLock)
            {
                if (connection == null)
                    connection = new Labaratory_DBEntities1();
                return connection;
            }
        }
    }
}
