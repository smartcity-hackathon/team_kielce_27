using System.Collections.Generic;
using hackathonProj.Model.Entities;
using hackathonProj.Model.SearchCriterias;

namespace hackathonProj.Interface
{
  public interface IKartaService
  {
    bool AddKarta(Karta karta);
    bool UpdateKarta(Karta karta);
    bool DeleteKarta(int? kartaId);
    Karta GetKarta(int? kartaId);
    IList<Karta> GetKartaList(KartaSC kartaSc);
  }
}
