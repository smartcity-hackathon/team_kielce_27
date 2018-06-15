﻿using System;
using System.Collections.Generic;
using System.Linq;
using Dapper.FastCrud;
using hackathonProj.Extensions;
using hackathonProj.Repository;

namespace hackathonProj.Model.Entities
{
  public class Urzad
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

  public static class UrzadDAO
  {
    public static bool Add(Urzad urzad)
    {
      using (var db = new BaseRepository())
      {
        if (urzad.IsNull())
          return false;

        db.Connection.Insert(urzad);
        return true;
      }
    }

    public static bool Update(Urzad urzad)
    {
      using (var db = new BaseRepository())
      {
        return !urzad.IsNull() && db.Connection.Update(urzad);
      }
    }

    public static bool Delete(int? urzadId)
    {
      using (var db = new BaseRepository())
      {
        return !(urzadId < 0) && db.Connection.Delete(new Urzad() { Id = urzadId });
      }
    }

    public static Urzad Get(int? urzadId)
    {
      using (var db = new BaseRepository())
      {
        var urzad = db.Connection.Get(new Urzad() { Id = urzadId });
        return urzad.IsNotNull() ? urzad : new Urzad();
      }
    }

    public static IList<Urzad> GetList(int startRecord = 0, int maxRecord = Int32.MaxValue)
    {
      using (var db = new BaseRepository())
      {
        return db.Connection.Find<Urzad>().ToList();
      }
    }
  }
}
