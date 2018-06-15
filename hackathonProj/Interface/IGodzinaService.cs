using System.Collections.Generic;
using hackathonProj.Model.Entities;
using hackathonProj.Model.SearchCriterias;

namespace hackathonProj.Interface
{
  public interface IGodzinaService
  {
    bool AddGodzina(Godzina godzina);
    bool UpdateGodzina(Godzina godzina);
    bool DeleteGodzina(int? godzinaId);
    Godzina GetGodzina(int? godzinaId);
    IList<Godzina> GetAccountList(GodzinaSC godzinaSc);
  }
}
