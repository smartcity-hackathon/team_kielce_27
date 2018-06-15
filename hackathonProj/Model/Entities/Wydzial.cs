using System;
using System.Collections.Generic;
using System.Linq;
using Dapper.FastCrud;
using hackathonProj.Extensions;
using hackathonProj.Repository;

namespace hackathonProj.Model.Entities
{
  public class Wydzial
  {
    public int? Id { get; set; }
    public string Nazwa { get; set; }
    public string Skrot { get; set; }
    public int? UrzadId { get; set; }
  }

  public static class WydzialDAO
  {
    public static bool Add(Wydzial wydzial)
    {
      using (var db = new BaseRepository())
      {
        if (wydzial.IsNull())
          return false;

        db.Connection.Insert(wydzial);
        return true;
      }
    }

    public static bool Update(Wydzial wydzial)
    {
      using (var db = new BaseRepository())
      {
        return !wydzial.IsNull() && db.Connection.Update(wydzial);
      }
    }

    public static bool Delete(int? wydzialId)
    {
      using (var db = new BaseRepository())
      {
        return !(wydzialId < 0) && db.Connection.Delete(new Wydzial() { Id = wydzialId });
      }
    }

    public static Wydzial Get(int? wydzialId)
    {
      using (var db = new BaseRepository())
      {
        var wydzial = db.Connection.Get(new Wydzial() { Id = wydzialId });
        return wydzial.IsNotNull() ? wydzial : new Wydzial();
      }
    }

    public static IList<Wydzial> GetList(int startRecord = 0, int maxRecord = Int32.MaxValue)
    {
      using (var db = new BaseRepository())
      {
        return db.Connection.Find<Wydzial>().ToList();
      }
    }
  }
}
