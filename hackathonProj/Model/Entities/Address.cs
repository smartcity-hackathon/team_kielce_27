using System;
using System.Collections.Generic;
using System.Linq;
using Dapper.FastCrud;
using hackathonProj.Extensions;
using hackathonProj.Repository;

namespace hackathonProj.Model.Entities
{
  public class Address
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

  public static class AddressDAO
  {
    public static bool Add(Address address)
    {
      using (var db = new BaseRepository())
      {
        if (address.IsNull())
          return false;

        db.Connection.Insert(address);
        return true;
      }
    }

    public static bool Update(Address address)
    {
      using (var db = new BaseRepository())
      {
        return !address.IsNull() && db.Connection.Update(address);
      }
    }

    public static bool Delete(int? addressId)
    {
      using (var db = new BaseRepository())
      {
        return !(addressId < 0) && db.Connection.Delete(new Address() { Id = addressId });
      }
    }

    public static Address Get(int? addressId)
    {
      using (var db = new BaseRepository())
      {
        var address = db.Connection.Get(new Address() { Id = addressId });
        return address.IsNotNull() ? address : new Address();
      }
    }

    public static IList<Address> GetList(int startRecord = 0, int maxRecord = Int32.MaxValue)
    {
      using (var db = new BaseRepository())
      {
        return db.Connection.Find<Address>().ToList();
      }
    }
  }
}
