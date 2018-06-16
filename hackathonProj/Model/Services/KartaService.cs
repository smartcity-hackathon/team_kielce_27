using System;
using System.Collections.Generic;
using System.Linq;
using hackathonProj.Extensions;
using hackathonProj.Interface;
using hackathonProj.Model.Entities;
using hackathonProj.Model.SearchCriterias;

namespace hackathonProj.Model.Services
{
  public class KartaService : IKartaService
  {
    public bool AddKarta(Karta karta)
    {
      return KartaDAO.Add(karta);
    }

    public bool UpdateKarta(Karta karta)
    {
      return KartaDAO.Update(karta);
    }

    public bool DeleteKarta(int? kartaId)
    {
      return KartaDAO.Delete(kartaId);
    }

    public Karta GetKarta(int? kartaId)
    {
      return KartaDAO.Get(kartaId);
    }

    public IList<Karta> GetKartaList(int startRecord = 0, int maxRecord = Int32.MaxValue, KartaSC kartaSc = null)
    {
      var list = KartaDAO.GetList();

      if (startRecord != 0)
        list = list.Skip(startRecord).ToList();
      if (maxRecord != 0)
        list = list.Take(maxRecord).ToList();
      if (kartaSc.IsNull())
        return list;

      if (kartaSc.Id.IsNotNull())
        list = list.Where(x => x.Id == kartaSc.Id).ToList();
      if (kartaSc.Numer.IsNotNull())
        list = list.Where(x => x.Numer == kartaSc.Numer).ToList();
      if (kartaSc.Nazwa.IsNotNull())
        list = list.Where(x => x.Nazwa.Equals(kartaSc.Nazwa)).ToList();
      if (kartaSc.Wydzial.IsNotNull())
        list = list.Where(x => x.WydzialId == kartaSc.Wydzial.Id).ToList();
      if (kartaSc.Tagi.IsNotNull())
        list = list.Where(x => x.Tagi.Equals(kartaSc.Tagi)).ToList();

      return list;
    }

    public Wydzial GetWydzial(int? kartaId)
    {
      var wydzialId = KartaDAO.Get(kartaId)?.WydzialId;
      var wydzial = WydzialDAO.Get(wydzialId);
      return wydzial.IsNotNull() ? wydzial : new Wydzial();
    }
  }
}
