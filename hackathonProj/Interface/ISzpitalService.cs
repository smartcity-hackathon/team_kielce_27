using System.Collections.Generic;
using hackathonProj.Model.Entities;
using hackathonProj.Model.SearchCriterias;

namespace hackathonProj.Interface
{
  interface ISzpitalService
  {
    bool AddSzpital(Szpital szpital);
    bool UpdateSzpital(Szpital szpital);
    bool DeleteSzpital(int? szpitalId);
    Szpital GetSzpital(int? szpitalId);
    IList<Szpital> GetSzpitalList(SzpitalSC accountSc);
  }
}
