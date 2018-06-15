using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace hackathonProj.Repository
{
    public class BaseRepository : IDisposable
    {
      public IDbConnection Connection;

      public BaseRepository()
      {
        var connectionString = "Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;";
        Connection = new MySqlConnection(connectionString);
        Connection.Open();
      }

      public void Dispose()
      {
        Connection.Close();
      }
    }
}
