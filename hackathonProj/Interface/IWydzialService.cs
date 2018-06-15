using System;
using System.Collections.Generic;
using hackathonProj.Model.Entities;
using hackathonProj.Model.SearchCriterias;

namespace hackathonProj.Interface
{
  public interface IWydzialService
  {
    bool AddWydzial(Wydzial wydzial);
    bool UpdateWydzial(Wydzial wydzial);
    bool DeleteWydzial(int? wydzialId);
    Wydzial GetWydzial(int? wydzialId);
    IList<Wydzial> GetWydzialList(int startRecord = 0, int maxRecord = Int32.MaxValue, WydzialSC wydzialSc = null);
    Urzad GetUrzad(int? wydzialId);
  }
}
