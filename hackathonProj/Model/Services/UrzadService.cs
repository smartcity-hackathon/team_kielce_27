using System;
using System.Collections.Generic;
using hackathonProj.Interface;
using hackathonProj.Model.Entities;
using hackathonProj.Model.SearchCriterias;

namespace hackathonProj.Model.Services
{
  public class UrzadService : IUrzadService
  {
    public bool AddUrzad(Urzad urzad)
    {
      return UrzadDAO.Add(urzad);
    }

    public bool UpdateUrzad(Urzad urzad)
    {
      return UrzadDAO.Update(urzad);
    }

    public bool DeleteUrzad(int? urzadId)
    {
      return UrzadDAO.Delete(urzadId);
    }

    public Urzad GetUrzad(int? urzadId)
    {
      return UrzadDAO.Get(urzadId);
    }

    public IList<Urzad> GetUrzadList(int startRecord = 0, int maxRecord = Int32.MaxValue, UrzadSC urzadSc = null)
    {
      //TODO: Search criteria
      return UrzadDAO.GetList();
    }
  }
}
