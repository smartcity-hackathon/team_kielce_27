using System.Collections.Generic;
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

    public IList<Karta> GetKartaList(KartaSC kartaSc)
    {
      //TODO: Search criteria
      return KartaDAO.GetList();
    }
  }
}
