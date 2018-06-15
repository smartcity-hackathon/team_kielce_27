using System;
using System.Collections.Generic;
using System.Linq;
using Dapper.FastCrud;
using hackathonProj.Extensions;
using hackathonProj.Repository;

namespace hackathonProj.Model.Entities
{
  public class Karta
  {
    public int? Id { get; set; }
    public string Numer { get; set; }
    public string Nazwa { get; set; }
    public int? WydzialId { get; set; }
    public string Tagi { get; set; }
  }

  public static class KartaDAO
  {
    public static bool Add(Karta karta)
    {
      using (var db = new BaseRepository())
      {
        if (karta.IsNull())
          return false;

        db.Connection.Insert(karta);
        return true;
      }
    }

    public static bool Update(Karta karta)
    {
      using (var db = new BaseRepository())
      {
        return !karta.IsNull() && db.Connection.Update(karta);
      }
    }

    public static bool Delete(int? kartaId)
    {
      using (var db = new BaseRepository())
      {
        return !(kartaId < 0) && db.Connection.Delete(new Karta() { Id = kartaId });
      }
    }

    public static Karta Get(int? kartaId)
    {
      using (var db = new BaseRepository())
      {
        var karta = db.Connection.Get(new Karta() { Id = kartaId });
        return karta.IsNotNull() ? karta : new Karta();
      }
    }

    public static IList<Karta> GetList(int startRecord = 0, int maxRecord = Int32.MaxValue)
    {
      using (var db = new BaseRepository())
      {
        return db.Connection.Find<Karta>().ToList();
      }
    }
  }
}
