using System.Collections.Generic;
using hackathonProj.Interface;
using hackathonProj.Model.Entities;
using hackathonProj.Model.SearchCriterias;

namespace hackathonProj.Model.Services
{
  public class AccountService : IAccountService
  {
    public bool AddAccount(Account account)
    {
      return AccountDAO.Add(account);
    }

    public bool UpdateAccount(Account account)
    {
      return AccountDAO.Update(account);
    }

    public bool DeleteAccount(int? accountId)
    {
      return AccountDAO.Delete(accountId);
    }

    public Account GetAccount(int? accountId)
    {
      return AccountDAO.Get(accountId);
    }

    public IList<Account> GetAccountList(AccountSC accountSc)
    {
      //TODO: Search criteria
      return AccountDAO.GetList();
    }
  }
}
