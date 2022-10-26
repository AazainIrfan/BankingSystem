using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class SavingAccount : BankAccount
    {

      
        public SavingAccount(AccountData ObjAd) : base(ObjAd)
        {
          
        }
        public void add_profit()
        {

            int PrevBalanace;
            PrevBalanace = CheckBalance();
            PrevBalanace = PrevBalanace + (PrevBalanace * 5 / 100);
            setbalance(PrevBalanace);
            


        }


    }
}
