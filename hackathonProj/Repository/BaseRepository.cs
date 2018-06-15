using System;
using System.Data;
using Dapper.FastCrud;
using MySql.Data.MySqlClient;

namespace hackathonProj.Repository
{
  public class BaseRepository : IDisposable
  {
    public IDbConnection Connection;

    public BaseRepository()
    {
      OrmConfiguration.DefaultDialect = SqlDialect.MySql;
      var a = new MySqlConnectionStringBuilder()
      {
        Server = "81.26.6.14",
        Database = "hackathon",
        UserID = "hackathon",
        Password = "pass",
        SslMode = MySqlSslMode.None
      };

      var connectionString = "Server=81.26.6.14;Database=hackathon;User Id=hackathon;Password = pass; SslMode = none;";
      Connection = new MySqlConnection(connectionString);
      Connection.Open();

    }

    public void Dispose()
    {
      Connection.Close();
    }
  }
}

