using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hackathonProj.Model.Entities;
using hackathonProj.Model.SearchCriterias;

namespace hackathonProj.Interface
{
  public interface IAddressService
  {
    bool AddAddress(Address address);
    bool UpdateAddress(Address address);
    bool DeleteAddress(int? addressId);
    Address GetAddress(int? addressId);
    IList<Address> GetAddressList(AddressSC addressSc);
  }
}
