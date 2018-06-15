using hackathonProj.Model.Entities;

namespace hackathonProj.Model.SearchCriterias
{
  public class GodzinaSC
  {
    public int? Id { get; set; }
    public Wydzial Wydzial { get; set; }
    public string Pon { get; set; }
    public string Wto { get; set; }
    public string Sro { get; set; }
    public string Czw { get; set; }
    public string Pia { get; set; }
    public string Sob { get; set; }
    public string Nie { get; set; }
  }
}
