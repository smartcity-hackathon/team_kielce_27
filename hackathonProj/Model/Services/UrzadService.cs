using System;
using System.Collections.Generic;
using System.Linq;
using hackathonProj.Extensions;
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
            var list = UrzadDAO.GetList();
            if (startRecord != 0)
                list = list.Skip(startRecord).ToList();
            if (maxRecord != 0)
                list = list.Take(maxRecord).ToList();

            if (urzadSc.IsNull())
                return list;
            if (urzadSc.Id.IsNotNull())
                list = list.Where(x => x.Id == urzadSc.Id).ToList();
            if (urzadSc.Nazwa.IsNotNull())
                list = list.Where(x => x.Nazwa.Equals(urzadSc.Id)).ToList();
            if (urzadSc.Ulica.IsNotNull())
                list = list.Where(x => x.Ulica.Equals(urzadSc.Ulica)).ToList();

            if (urzadSc.NumerBudynku.IsNotNull())
                list = list.Where(x => x.NumerBudynku.Equals(urzadSc.NumerBudynku)).ToList();
           
            if (urzadSc.KodPocztowy.IsNotNull())
                list = list.Where(x => x.KodPocztowy.Equals(urzadSc.KodPocztowy)).ToList();
            if (urzadSc.Telefon.IsNotNull())
                list = list.Where(x => x.Telefon.Equals(urzadSc.Telefon)).ToList();
            if (urzadSc.WWW.IsNotNull())
                list = list.Where(x => x.WWW.Equals(urzadSc.WWW)).ToList();
            if (urzadSc.json_ogc.IsNotNull())
                list = list.Where(x => x.json_ogc.Equals(urzadSc.json_ogc)).ToList();
            if (urzadSc.json_geo.IsNotNull())
                list = list.Where(x => x.json_geo.Equals(urzadSc.json_geo)).ToList();

            return list;
    }
  }
}
