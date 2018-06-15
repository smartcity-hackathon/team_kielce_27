using System.Collections.Generic;
using hackathonProj.Model.Entities;
using hackathonProj.Model.SearchCriterias;

namespace hackathonProj.Interface
{
    interface ITerminService
    {
      bool AddTermin(Termin termin);
      bool UpdateTermin(Termin termin);
      bool DeleteTermin(int? terminId);
      Termin GetTermin(int? terminId);
      IList<Termin> GetTerminList(TerminSC accountSc);
      Account GetAccount(int? terminId);
      Wydzial GetWydzial(int? terminId);
      Karta GetKarta(int? terminId);
    }
}
