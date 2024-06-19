using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class AccountDAO
    {
        public static AccountMember GetAccountById(string aid)
        {
            var myContextDB = new MyStoreContext();
            return myContextDB.AccountMembers.FirstOrDefault(i => i.EmailAddress.Equals(aid));
        }
    }
}
