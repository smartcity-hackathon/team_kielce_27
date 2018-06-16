using System;
using System.Collections.Generic;
using System.Linq;
using hackathonProj.Extensions;
using hackathonProj.Interface;
using hackathonProj.Model.Entities;
using hackathonProj.Model.SearchCriterias;

namespace hackathonProj.Model.Services
{
  public class TerminService : ITerminService
  {
    public bool AddTermin(Termin termin)
    {
      return TerminDAO.Add(termin);
    }

    public bool UpdateTermin(Termin termin)
    {
      return TerminDAO.Update(termin);
    }

    public bool DeleteTermin(int? terminId)
    {
      return TerminDAO.Delete(terminId);
    }

    public Termin GetTermin(int? terminId)
    {
      return TerminDAO.Get(terminId);
    }

    public Account GetAccount(int? terminId)
    {
      var accountId = TerminDAO.Get(terminId)?.AccountId;
      var account = AccountDAO.Get(accountId);
      return account.IsNotNull() ? account : new Account();
    }

    public Wydzial GetWydzial(int? terminId)
    {
      var wydzialId = TerminDAO.Get(terminId)?.AccountId;
      var wydzial = WydzialDAO.Get(wydzialId);
      return wydzial.IsNotNull() ? wydzial : new Wydzial();
    }

    public Karta GetKarta(int? terminId)
    {
      var kartaId = TerminDAO.Get(terminId)?.AccountId;
      var karta = KartaDAO.Get(kartaId);
      return karta.IsNotNull() ? karta : new Karta();
    }

    public IList<Termin> GetTerminList(int startRecord = 0, int maxRecord = Int32.MaxValue, TerminSC terminSc = null)
    {
      var list = TerminDAO.GetList();
      if (startRecord != 0)
        list = list.Skip(startRecord).ToList();
      if (maxRecord != 0)
        list = list.Take(maxRecord).ToList();
      if (terminSc.Id.IsNotNull())
        list = list.Where(x => x.Id == terminSc.Id).ToList();
      if (terminSc.Account.IsNotNull())
        list = list.Where(x => x.AccountId == terminSc.Account.Id).ToList();
      if (terminSc.Wydzial.IsNotNull())
        list = list.Where(x => x.WydzialId == terminSc.Wydzial.Id).ToList();
      if (terminSc.CzasStworzenia.IsNotNull())
        list = list.Where(x => x.CzasStworzenia == terminSc.CzasStworzenia).ToList();
      if (terminSc.CzasUmowienia.IsNotNull())
        list = list.Where(x => x.CzasStworzenia == terminSc.CzasUmowienia).ToList();
      if (terminSc.Karta.IsNotNull())
        list = list.Where(x => x.KartaId == terminSc.Karta.Id).ToList();
      if (terminSc.Aktywny.IsNotNull())
        list = list.Where(x => x.Aktywny == terminSc.Aktywny).ToList();
      return list;

    }
  }
}
