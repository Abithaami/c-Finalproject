using System.Data.SQLite;

namespace c_finalproject
{
    static class dbconfig
    {
        private static readonly string ConnectionString = "Data Source=School_DBMS.db;Version=3;";

        public static SQLiteConnection getConnection()
        {
            return new SQLiteConnection(ConnectionString);
        }
    }
}
