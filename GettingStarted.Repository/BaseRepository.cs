using Npgsql;
using System.Data;

namespace GettingStarted.Repository
{
    public class BaseRepository
    {
        protected IDbConnection con;
        public BaseRepository()
        {
            string connectionString = "Data Source=****;Initial Catalog=DataManagement;Integrated Security=True";
            con = new NpgsqlConnection();
        }
        public void Dispose()
        {
            //throw new NotImplementedException();  
        }
    }
}
