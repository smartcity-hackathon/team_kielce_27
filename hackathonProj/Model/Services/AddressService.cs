using System.Collections.Generic;
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

    public IList<Address> GetAddressList(AddressSC accountSc)
    {
      //TODO: Search criteria
      return AddressDAO.GetList();
    }
  }
}
