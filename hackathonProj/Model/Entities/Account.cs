using System;
using System.Collections.Generic;
using System.Linq;
using Dapper.FastCrud;
using hackathonProj.Repository;
using hackathonProj.Extensions;
using hackathonProj.Model.SearchCriterias;

namespace hackathonProj.Model.Entities
{
  public class Account
  {
    public int? Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Name1 { get; set; }
    public string Name2 { get; set; }
    public string Surname { get; set; }
    public char Sex { get; set; }
    public string Key { get; set; }
    public char AccountType { get; set; }
  }

  public static class AccountDAO
  {
    public static bool Add(Account account)
    {
      using (var db = new BaseRepository())
      {
        if (account.IsNull())
          return false;

        db.Connection.Insert(account);
        return true;
      }
    }

    public static bool Update(Account account)
    {
      using (var db = new BaseRepository())
      {
        return !account.IsNull() && db.Connection.Update(account);
      }
    }

    public static bool Delete(int? accountId)
    {
      using (var db = new BaseRepository())
      {
        return !(accountId < 0) && db.Connection.Delete(accountId);
      }
    }

    public static Account Get(int? accountId)
    {
      using (var db = new BaseRepository())
      {
        var account = db.Connection.Get(new Account() {Id = accountId});
        return account.IsNotNull() ? account : new Account();
      }
    }

    public static IList<Account> GetList(int startRecord = 0, int maxRecord = Int32.MaxValue)
    {
      using (var db = new BaseRepository())
      {
       return db.Connection.Find<Account>().ToList();
      }
    }
  }
}
