using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<Tuple<string, string, string, int>> parseddata() {
            var lista = GetAccountList();
            var temp = new List<Tuple<string, string, string, int>>();
            foreach (Godzina x in lista)
            {
                string od,doo;
                int index = x.Pon.IndexOf("-");
                od = x.Pon.Substring(0, index);
                doo = x.Pon.Substring(index, x.Pon.Length);


                temp.Append(new Tuple<string, string, string, int>(od, doo, nameof(x.Pon),(int)x.WydzialId));
                temp.Append(new Tuple<string, string, string, int>(od, doo, nameof(x.Wto), (int)x.WydzialId));
                temp.Append(new Tuple<string, string, string, int>(od, doo, nameof(x.Sro), (int)x.WydzialId));
                temp.Append(new Tuple<string, string, string, int>(od, doo, nameof(x.Czw), (int)x.WydzialId));
                temp.Append(new Tuple<string, string, string, int>(od, doo, nameof(x.Pia), (int)x.WydzialId));
                if(x.Sob != null)
                    temp.Append(new Tuple<string, string, string, int>(od, doo, nameof(x.Sob), (int)x.WydzialId));

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

      //TODO: NORMALNE porównywanie godzin pracy
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
