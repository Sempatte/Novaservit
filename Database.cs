
namespace Funda_Trabajo_Parcial
{


    public class Database : DBEntities
    {
        public static DBEntities Main { get; set; }

        private DBEntities db;

        public Database()
        {
            db = new DBEntities();  // Database
            Main = db;
        }
    }
}
