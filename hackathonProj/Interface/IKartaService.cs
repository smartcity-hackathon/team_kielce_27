using System;
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
    IList<Karta> GetKartaList(int startRecord = 0, int maxRecord = Int32.MaxValue, KartaSC kartaSc = null);
    Wydzial GetWydzial(int? kartaId);
  }
}
