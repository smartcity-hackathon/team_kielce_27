using hackathonProj.Model.Entities;

namespace hackathonProj.Model.SearchCriterias
{
  public class WydzialSC
  {
    public int? Id { get; set; }
    public string Nazwa { get; set; }
    public string Skrot { get; set; }
    public Urzad Urzad { get; set; }
  }
}
