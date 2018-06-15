namespace hackathonProj.Model.Entities
{
    public class Address
    {
      public int? Id { get; set; }
      public string Street { get; set; }
      public string Building { get; set; }
      public string SubBuilding { get; set; }
      public string Apartment { get; set; }
      public string Postcode { get; set; }
      public string City { get; set; }
    }
}
