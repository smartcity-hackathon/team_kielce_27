using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using hackathonProj.Extensions;
using hackathonProj.Interface;
using hackathonProj.Model.Entities;
using hackathonProj.Model.SearchCriterias;

namespace hackathonProj.Model.Services
{
  public class GodzinaService : IGodzinaService
  {
    public bool AddGodzina(Godzina godzina)
    {
      return GodzinaDAO.Add(godzina);
    }

    public bool UpdateGodzina(Godzina godzina)
    {
      return GodzinaDAO.Update(godzina);
    }

    public bool DeleteGodzina(int? godzinaId)
    {
      return GodzinaDAO.Delete(godzinaId);
    }

    public Godzina GetGodzina(int? godzinaId)
    {
      return GodzinaDAO.Get(godzinaId);
    }

    public List<TimeObject> ParseTimes()
    {
      var lista = GodzinaDAO.GetList();
      var temp = new List<TimeObject>();

      foreach (Godzina x in lista)
      {
        PropertyInfo[] properties = x.GetType().GetProperties();
        foreach (var PropertyInfo in properties)
        {
          if (PropertyInfo.Name == "Id" || PropertyInfo.Name == "WydzialId" ||
              !PropertyInfo.GetValue(x, null).IsNotNull()) continue;
          var str = PropertyInfo.GetValue(x, null).ToString().Replace(" ", "");
          var parts = str.Split('-');
          temp.Add(new TimeObject()
          {
            TimeOd = parts[0],
            TimeDo = parts[1],
            Day = PropertyInfo.Name,
            wydzialId = (int)x.Id
          });
        }
      }

      return temp;
    }

    public IList<Godzina> GetAccountList(int startRecord = 0, int maxRecord = Int32.MaxValue, GodzinaSC godzinaSc = null)
    {
      var list = GodzinaDAO.GetList();

      if (startRecord != 0)
        list = list.Skip(startRecord).ToList();
      if (maxRecord != 0)
        list = list.Take(maxRecord).ToList();
      if (godzinaSc.IsNull()) return list;

      if (godzinaSc.Id.IsNotNull())
        list = list.Where(x => x.Id == godzinaSc.Id).ToList();
      if (godzinaSc.Wydzial.IsNotNull())
        list = list.Where(x => x.WydzialId == godzinaSc.Wydzial.Id).ToList();
      if (godzinaSc.Pon.IsNotNull())
        list = list.Where(x => x.Pon.Equals(godzinaSc.Pon)).ToList();
      if (godzinaSc.Wto.IsNotNull())
        list = list.Where(x => x.Wto.Equals(godzinaSc.Wto)).ToList();
      if (godzinaSc.Sro.IsNotNull())
        list = list.Where(x => x.Sro.Equals(godzinaSc.Sro)).ToList();
      if (godzinaSc.Czw.IsNotNull())
        list = list.Where(x => x.Czw.Equals(godzinaSc.Czw)).ToList();
      if (godzinaSc.Pia.IsNotNull())
        list = list.Where(x => x.Pia.Equals(godzinaSc.Pia)).ToList();
      if (godzinaSc.Sob.IsNotNull())
        list = list.Where(x => x.Sob.Equals(godzinaSc.Sob)).ToList();
      if (godzinaSc.Nie.IsNotNull())
        list = list.Where(x => x.Nie.Equals(godzinaSc.Nie)).ToList();

      return list;
    }

    public Wydzial GetWydzial(int? godzinaId)
    {
      var wydzialId = GodzinaDAO.Get(godzinaId)?.WydzialId;
      var wydzial = WydzialDAO.Get(wydzialId);
      return wydzial.IsNotNull() ? wydzial : new Wydzial();
    }
  }
}
