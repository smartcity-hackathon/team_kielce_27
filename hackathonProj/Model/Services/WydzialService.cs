using System;
using System.Collections.Generic;
using System.Linq;
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
            var list = WydzialDAO.GetList();

            if (startRecord != 0)
                list = list.Skip(startRecord).ToList();
            if (maxRecord != 0)
                list = list.Take(maxRecord).ToList();
            if (wydzialSc.IsNull())
                return list;
            if (wydzialSc.Id.IsNotNull())
                list = list.Where(x => x.Id == wydzialSc.Id).ToList();
            if (wydzialSc.Nazwa.IsNotNull())
                list = list.Where(x => x.Nazwa.Equals(wydzialSc.Nazwa)).ToList();
            if (wydzialSc.Skrot.IsNotNull())
                list = list.Where(x => x.Skrot.Equals(wydzialSc.Skrot)).ToList();
            if (wydzialSc.Urzad.Id.IsNotNull())
                list = list.Where(x => x.UrzadId == wydzialSc.Urzad.Id).ToList();
            return list;
    }

    public Urzad GetUrzad(int? wydzialId)
    {
      var urzadId = WydzialDAO.Get(wydzialId)?.UrzadId;
      var urzad = UrzadDAO.Get(urzadId);
      return urzad.IsNotNull() ? urzad : new Urzad();
    }
  }
}
