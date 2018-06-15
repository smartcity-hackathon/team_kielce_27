using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hackathonProj.Model.Entities;
using hackathonProj.Model.SearchCriterias;

namespace hackathonProj.Interface
{
    public interface IAccountService
    {
      bool AddAccount(Account account);
      bool UpdateAccount(Account account);
      bool DeleteAccount(int? accountId);
      Account GetAccount(int? accountId);
      IList<Account> GetAccountList(AccountSC accountSc);
    }
}
