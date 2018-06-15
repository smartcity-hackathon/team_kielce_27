namespace hackathonProj.Model.Entities
{
    public class Urzad
    {
      public int? Id { get; set; }
      public string Nazwa { get; set; }
      public string Ulica { get; set; }
      public string NumerBudynku { get; set; }
      public string KodPocztowy { get; set; }
      public string Telefon { get; set; }
      public string WWW { get; set; }

      //TODO: json_ogc, json_geo
    }
}
