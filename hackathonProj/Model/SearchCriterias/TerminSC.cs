using System;
using hackathonProj.Model.Entities;

namespace hackathonProj.Model.SearchCriterias
{
  public class TerminSC
  {
    public int? Id { get; set; }
    public Account Account { get; set; }
    public Wydzial Wydzial { get; set; }
    public DateTime CzasStworzenia { get; set; }
    public DateTime CzasUmowienia { get; set; }
    public Karta Karta { get; set; }
    public bool Aktywny { get; set; }
  }
}
