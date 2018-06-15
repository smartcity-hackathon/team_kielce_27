using hackathonProj.Model.Entities;

namespace hackathonProj.Model.SearchCriterias
{
  public class KartaSC
  {
    public int? Id { get; set; }
    public int Numer { get; set; }
    public string Nazwa { get; set; }
    public Wydzial Wydzial { get; set; }
    public string Tagi { get; set; }
  }
}
