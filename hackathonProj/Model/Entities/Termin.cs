using System;
using System.Collections.Generic;
using System.Linq;
using Dapper.FastCrud;
using hackathonProj.Extensions;
using hackathonProj.Repository;

namespace hackathonProj.Model.Entities
{
  public class Termin
  {
    public int? Id { get; set; }
    public int AccountId { get; set; }
    public int WydzialId { get; set; }
    public DateTime CzasStworzenia { get; set; }
    public DateTime CzasUmowienia { get; set; }
    public int KartaId { get; set; }
    public bool Aktywny { get; set; }
  }

  public static class TerminDAO
  {
    public static bool Add(Termin termin)
    {
      using (var db = new BaseRepository())
      {
        if (termin.IsNull())
          return false;

        db.Connection.Insert(termin);
        return true;
      }
    }

    public static bool Update(Termin termin)
    {
      using (var db = new BaseRepository())
      {
        return !termin.IsNull() && db.Connection.Update(termin);
      }
    }

    public static bool Delete(int? terminId)
    {
      using (var db = new BaseRepository())
      {
        return !(terminId < 0) && db.Connection.Delete(new Termin() { Id = terminId });
      }
    }

    public static Termin Get(int? terminId)
    {
      using (var db = new BaseRepository())
      {
        var termin = db.Connection.Get(new Termin() { Id = terminId });
        return termin.IsNotNull() ? termin : new Termin();
      }
    }

    public static IList<Termin> GetList(int startRecord = 0, int maxRecord = Int32.MaxValue)
    {
      using (var db = new BaseRepository())
      {
        return db.Connection.Find<Termin>().ToList();
      }
    }
  }
}
