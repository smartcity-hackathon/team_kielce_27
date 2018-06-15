using System.Collections.Generic;
using hackathonProj.Interface;
using hackathonProj.Model.Entities;
using hackathonProj.Model.SearchCriterias;

namespace hackathonProj.Model.Services
{
  public class SzpitalService : ISzpitalService
  {
    public bool AddSzpital(Szpital szpital)
    {
      return SzpitalDAO.Add(szpital);
    }

    public bool UpdateSzpital(Szpital szpital)
    {
      return SzpitalDAO.Update(szpital);
    }

    public bool DeleteSzpital(int? szpitalId)
    {
      return SzpitalDAO.Delete(szpitalId);
    }

    public Szpital GetSzpital(int? szpitalId)
    {
      return SzpitalDAO.Get(szpitalId);
    }

    public IList<Szpital> GetSzpitalList(SzpitalSC szpitalSc)
    {
      //TODO: Search criteria
      return SzpitalDAO.GetList();
    }
  }
}
