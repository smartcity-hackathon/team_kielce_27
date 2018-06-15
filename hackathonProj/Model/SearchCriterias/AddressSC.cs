namespace hackathonProj.Model.SearchCriterias
{
  public class AddressSC
  {
    public int? Id { get; set; }
    public int? AccountId { get; set; }
    public string Street { get; set; }
    public string Building { get; set; }
    public string SubBuilding { get; set; }
    public string Apartment { get; set; }
    public string Postcode { get; set; }
    public string City { get; set; }
  }
}
