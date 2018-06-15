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
    IList<Wydzial> GetWydzialList(WydzialSC wydzialSc);
    Urzad GetUrzad(int? wydzialId);
  }
}
