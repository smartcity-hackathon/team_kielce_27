using System.Collections.Generic;
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

    public IList<Termin> GetTerminList(TerminSC accountSc)
    {
      //TODO: Search criteria
      return TerminDAO.GetList();
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
  }
}
