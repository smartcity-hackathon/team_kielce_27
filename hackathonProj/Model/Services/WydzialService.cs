using System.Collections.Generic;
using hackathonProj.Interface;
using hackathonProj.Model.Entities;
using hackathonProj.Model.SearchCriterias;

namespace hackathonProj.Model.Services
{
  public class WydzialService : IWydzialService
  {
    public bool AddWydzial(Wydzial wydzial)
    {
      return WydzialDAO.Add(wydzial);
    }

    public bool UpdateWydzial(Wydzial wydzial)
    {
      return WydzialDAO.Update(wydzial);
    }

    public bool DeleteWydzial(int? wydzialId)
    {
      return WydzialDAO.Delete(wydzialId);
    }

    public Wydzial GetUrzad(int? wydzialId)
    {
      return WydzialDAO.Get(wydzialId);
    }

    public IList<Wydzial> GetWydzialList(WydzialSC wydzialSc)
    {
      //TODO: Search criteria
      return WydzialDAO.GetList();
    }
  }
}
