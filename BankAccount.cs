using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class BankAccount

    {
        public string AccountHolderName { get;  }
        public string AccountNumber { get; }
        int AccountBalance; 
     
      


        public BankAccount(AccountData  ObjAd) //Constructor
        {
            AccountHolderName = ObjAd.AccountHolderName;
            AccountNumber = ObjAd.AccountNumber;
            AccountBalance = ObjAd.AccountBalance;


        }
        public void AddBalance(int Added_balance)
        {
            AccountBalance += Added_balance;

        }

        public void WithdrawAmount(int withdraw_balance)
        {
            AccountBalance-=withdraw_balance;

        }

        public int CheckBalance()
        {
            return AccountBalance;

        }
      
        public static void setbalance(int balance)
        {
            
        }


    }
}
