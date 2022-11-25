using Abstraction.Interfaces;

namespace Abstraction.Models
{
    internal class SqlLiteDataAccess : IDataAccess
    {
        public string LoadConnectionString(string name)
        {
            Console.WriteLine("Load Connection String");
            return "testConnectionString";
        }
        public void LoadData(string sql)
        {
            Console.WriteLine("Loading Microsoft SQLite Data");
        }
        public void SaveData(string sql)
        {
            Console.WriteLine("Saving data to SQLite");
        }
    }
}
