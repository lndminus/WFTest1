using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkFinder.Models
{
    public class AuthorizationManager
    {
        public bool CheckAuthorization(IEnumerable<IAccount> accounts, string login, string password)
        {
            if (this.FindLogin(accounts, login))
            {
                IAccount account = this.GetAccount(accounts, login);
                if (account != null)
                {
                    if (account.Login == login && account.Password == password)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool FindLogin(IEnumerable<IAccount> accounts, string login)
        {
            foreach (IAccount a in accounts)
            {
                if (a.Login == login)
                {
                    return true;
                }
            }
            return false;
        }

        public IAccount GetAccount(IEnumerable<IAccount> accounts, string login)
        {
            IAccount account = null;
            foreach (IAccount a in accounts)
            {
                if (a.Login == login)
                {
                    account = a;
                }
            }
            return account;
        }

        public IAccount GetAccountById(IEnumerable<IAccount> accounts, int id)
        {
            IAccount account = null;
            foreach (IAccount a in accounts)
            {
                if (a.Id == id)
                {
                    account = a;
                }
            }
            return account;
        }
    }
}
