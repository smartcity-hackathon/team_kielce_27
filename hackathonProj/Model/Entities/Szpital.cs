using System;
using System.Collections.Generic;
using System.Linq;
using Dapper.FastCrud;
using hackathonProj.Extensions;
using hackathonProj.Repository;

namespace hackathonProj.Model.Entities
{
  public class Szpital
  {
    public int? Id { get; set; }
    public string Nazwa { get; set; }
    public string Ulica { get; set; }
    public string NumerBudynku { get; set; }
    public string KodPocztowy { get; set; }
    public string Telefon { get; set; }
    public string WWW { get; set; }
    public string json_ogc { get; set; }
    public string json_geo { get; set; }
  }

  public static class SzpitalDAO
  {
    public static bool Add(Szpital szpital)
    {
      using (var db = new BaseRepository())
      {
        if (szpital.IsNull())
          return false;

        db.Connection.Insert(szpital);
        return true;
      }
    }

    public static bool Update(Szpital szpital)
    {
      using (var db = new BaseRepository())
      {
        return !szpital.IsNull() && db.Connection.Update(szpital);
      }
    }

    public static bool Delete(int? szpitalId)
    {
      using (var db = new BaseRepository())
      {
        return !(szpitalId < 0) && db.Connection.Delete(new Szpital() { Id = szpitalId });
      }
    }

    public static Szpital Get(int? szpitalId)
    {
      using (var db = new BaseRepository())
      {
        var szpital = db.Connection.Get(new Szpital() { Id = szpitalId });
        return szpital.IsNotNull() ? szpital : new Szpital();
      }
    }

    public static IList<Szpital> GetList(int startRecord = 0, int maxRecord = Int32.MaxValue)
    {
      using (var db = new BaseRepository())
      {
        return db.Connection.Find<Szpital>().ToList();
      }
    }
  }
}
