using System;
using System.Collections.Generic;
using System.Linq;
using hackathonProj.Extensions;
using hackathonProj.Interface;
using hackathonProj.Model.Entities;
using hackathonProj.Model.SearchCriterias;

namespace hackathonProj.Model.Services
{
  public class AddressService : IAddressService
  {
    public bool AddAddress(Address address)
    {
      return AddressDAO.Add(address);
    }

    public bool UpdateAddress(Address address)
    {
      return AddressDAO.Update(address);
    }

    public bool DeleteAddress(int? addressId)
    {
      return AddressDAO.Delete(addressId);
    }

    public Address GetAddress(int? addressId)
    {
      return AddressDAO.Get(addressId);
    }

    public IList<Address> GetAddressList(int startRecord = 0, int maxRecord = Int32.MaxValue, AddressSC addressSc = null)
    {
      var list = AddressDAO.GetList();

      if (startRecord != 0)
        list = list.Skip(startRecord).ToList();
      if (maxRecord != 0)
        list = list.Take(maxRecord).ToList();
      if (addressSc.IsNull()) return list;

      if (addressSc.Id.IsNotNull())
        list = list.Where(x => x.Id == addressSc.Id).ToList();
      if (addressSc.AccountId.IsNotNull())
        list = list.Where(x => x.AccountId == addressSc.AccountId).ToList();
      if (addressSc.Street.IsNotNull())
        list = list.Where(x => x.Street == addressSc.Street).ToList();
      if (addressSc.Building.IsNotNull())
        list = list.Where(x => x.Building == addressSc.Building).ToList();
      if (addressSc.SubBuilding.IsNotNull())
        list = list.Where(x => x.SubBuilding == addressSc.SubBuilding).ToList();
      if (addressSc.Apartment.IsNotNull())
        list = list.Where(x => x.Apartment == addressSc.Apartment).ToList();
      if (addressSc.Postcode.IsNotNull())
        list = list.Where(x => x.Postcode == addressSc.Postcode).ToList();
      if (addressSc.City.IsNotNull())
        list = list.Where(x => x.City == addressSc.City).ToList();
      return list;
    }
  }
}
