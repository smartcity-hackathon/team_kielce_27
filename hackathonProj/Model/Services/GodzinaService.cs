using System.Collections.Generic;
using hackathonProj.Interface;
using hackathonProj.Model.Entities;
using hackathonProj.Model.SearchCriterias;

namespace hackathonProj.Model.Services
{
  public class GodzinaService : IGodzinaService
  {
    public bool AddGodzina(Godzina godzina)
    {
      return GodzinaDAO.Add(godzina);
    }

    public bool UpdateGodzina(Godzina godzina)
    {
      return GodzinaDAO.Update(godzina);
    }

    public bool DeleteGodzina(int? godzinaId)
    {
      return GodzinaDAO.Delete(godzinaId);
    }

    public Godzina GetGodzina(int? godzinaId)
    {
      return GodzinaDAO.Get(godzinaId);
    }

    public IList<Godzina> GetAccountList(GodzinaSC godzinaSc)
    {
      //TODO: Search criteria
      return GodzinaDAO.GetList();
    }
  }
}
