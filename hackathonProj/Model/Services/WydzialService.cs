using System;
using System.Collections.Generic;
using hackathonProj.Extensions;
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

    public Wydzial GetWydzial(int? wydzialId)
    {
      return WydzialDAO.Get(wydzialId);
    }

    public IList<Wydzial> GetWydzialList(int startRecord = 0, int maxRecord = Int32.MaxValue, WydzialSC wydzialSc = null)
    {
      //TODO: Search criteria
      return WydzialDAO.GetList();
    }

    public Urzad GetUrzad(int? wydzialId)
    {
      var urzadId = WydzialDAO.Get(wydzialId)?.UrzadId;
      var urzad = UrzadDAO.Get(urzadId);
      return urzad.IsNotNull() ? urzad : new Urzad();
    }
  }
}
