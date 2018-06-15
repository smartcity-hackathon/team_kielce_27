using System;
using System.Collections.Generic;
using System.Linq;
using hackathonProj.Extensions;
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

    public IList<Account> GetAccountList(int startRecord = 0, int maxRecord = Int32.MaxValue, AccountSC accountSc = null)
    {
      var list = AccountDAO.GetList();

      if (startRecord != 0)
        list = list.Skip(startRecord).ToList();
      if(maxRecord != 0)
        list = list.Take(maxRecord).ToList();
      if (accountSc.IsNull()) return list;

      if (accountSc.Id.IsNotNull())
        list = list.Where(x => x.Id == accountSc.Id).ToList();
      if (accountSc.Username.IsNotNull())
        list = list.Where(x => x.Username == accountSc.Username).ToList();
      if (accountSc.Password.IsNotNull())
        //TODO: szyfrowanie hasla
        list = list.Where(x => x.Password == accountSc.Password).ToList();
      if (accountSc.Email.IsNotNull())
        list = list.Where(x => x.Email == accountSc.Email).ToList();
      if (accountSc.Name1.IsNotNull())
        list = list.Where(x => x.Name1 == accountSc.Name1).ToList();
      if (accountSc.Name2.IsNotNull())
        list = list.Where(x => x.Name2 == accountSc.Name2).ToList();
      if (accountSc.Surname.IsNotNull())
        list = list.Where(x => x.Surname == accountSc.Surname).ToList();
      if (accountSc.Sex.IsNotNull())
        list = list.Where(x => x.Sex == accountSc.Sex).ToList();
      if (accountSc.Key.IsNotNull())
        list = list.Where(x => x.Key == accountSc.Key).ToList();
      if (accountSc.AccountType.IsNotNull())
        list = list.Where(x => x.AccountType == accountSc.AccountType).ToList();
      return list;
    }
  }
}
