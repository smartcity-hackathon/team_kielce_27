using System;
using System.Collections.Generic;
using hackathonProj.Model.Entities;
using hackathonProj.Model.SearchCriterias;

namespace hackathonProj.Interface
{
  public interface IUrzadService
  {
    bool AddUrzad(Urzad urzad);
    bool UpdateUrzad(Urzad urzad);
    bool DeleteUrzad(int? urzadId);
    Urzad GetUrzad(int? urzadId);
    IList<Urzad> GetUrzadList(int startRecord = 0, int maxRecord = Int32.MaxValue, UrzadSC accountSc = null);
  }
}
