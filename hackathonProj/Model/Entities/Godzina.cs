using System;
using System.Collections.Generic;
using System.Linq;
using Dapper.FastCrud;
using hackathonProj.Extensions;
using hackathonProj.Repository;

namespace hackathonProj.Model.Entities
{
  public class Godzina
  {
    public int? Id { get; set; }
    public int? WydzialId { get; set; }
    public string Pon { get; set; }
    public string Wto { get; set; }
    public string Sro { get; set; }
    public string Czw { get; set; }
    public string Pia { get; set; }
    public string Sob { get; set; }
    public string Nie { get; set; }
  }

  public static class GodzinaDAO
  {
    public static bool Add(Godzina godzina)
    {
      using (var db = new BaseRepository())
      {
        if (godzina.IsNull())
          return false;

        db.Connection.Insert(godzina);
        return true;
      }
    }

    public static bool Update(Godzina godzina)
    {
      using (var db = new BaseRepository())
      {
        return !godzina.IsNull() && db.Connection.Update(godzina);
      }
    }

    public static bool Delete(int? godzinaId)
    {
      using (var db = new BaseRepository())
      {
        return !(godzinaId < 0) && db.Connection.Delete(new Godzina() { Id = godzinaId });
      }
    }

    public static Godzina Get(int? godzinaId)
    {
      using (var db = new BaseRepository())
      {
        var godzina = db.Connection.Get(new Godzina() { Id = godzinaId });
        return godzina.IsNotNull() ? godzina : new Godzina();
      }
    }

    public static IList<Godzina> GetList(int startRecord = 0, int maxRecord = Int32.MaxValue)
    {
      using (var db = new BaseRepository())
      {
        return db.Connection.Find<Godzina>().ToList();
      }
    }
  }
}
