using System;
using System.Collections.Generic;
using System.Linq;


namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int user_want;
            string user_acc_number;
            int flag = 0;

            List<BankAccount> acc_info = new List<BankAccount>();


            while (true)
            {
                //this line is added by ihsan
                //file edited by aazain
                Console.WriteLine("**Welcome to my bank");
                Console.WriteLine("Press 1 to Check balance");
                Console.WriteLine("Press 2 to Add balance");
                Console.WriteLine("Press 3 to withdraw balance");
                Console.WriteLine("Press 4 to create account");
                Console.WriteLine("Press 5 to add Profit of saving account");
                user_want = Convert.ToInt32(Console.ReadLine());


                switch (user_want)
                {
                    case 1:
                        Console.WriteLine("What is your account number");
                        user_acc_number = Console.ReadLine();
                        for (int i = 0; i < acc_info.Count(); i++)
                        {
                            if (user_acc_number == acc_info[i].AccountNumber)
                            {
                                Console.WriteLine("your balance is {0}", acc_info[i].CheckBalance());
                                flag = 1;
                            }
                        }
                        if (flag == 0) 
                            {
                            Console.WriteLine("account number not found");
                            }
                
                         break;

                    case 2:
                        int balance_added;
                        Console.WriteLine("What is your account number");
                        user_acc_number = Console.ReadLine();
                        Console.WriteLine("How much balance do you want to add ?");
                        balance_added = Convert.ToInt32(Console.ReadLine());
                        if (balance_added > 0)
                        {
                            for (int i = 0; i < acc_info.Count(); i++)
                            {
                                if (user_acc_number == acc_info[i].AccountNumber)
                                {
                                    acc_info[i].AddBalance(balance_added);
                                    Console.WriteLine("your balance is added and your new balance is {0}", acc_info[i].CheckBalance());
                                    flag = 1;


                                }

                                
                            }
                            if (flag == 0)
                            {
                                Console.WriteLine("account number not found");
                            }
                        }
                              
                        else
                        {
                            Console.WriteLine("invalid amount entered, please try again");
                        }
                        break;

                    case 3:
                        int balance_withdrawn;
                        Console.WriteLine("What is your account number");
                        user_acc_number = Console.ReadLine();
                        Console.WriteLine("How much balance do you want to withdraw ?");
                        balance_withdrawn = Convert.ToInt32(Console.ReadLine());
                        if (balance_withdrawn > 0)
                        {
                            for (int i = 0; i < acc_info.Count(); i++)
                            {
                                if (user_acc_number == acc_info[i].AccountNumber)
                                {
                                    if (acc_info[i].CheckBalance() >= balance_withdrawn)
                                    {
                                        acc_info[i].WithdrawAmount(balance_withdrawn);
                                        Console.WriteLine("Balance has been withdrawn from your acoount and your new balance is {0}", acc_info[i].CheckBalance());
                                    }
                                    else
                                        Console.WriteLine("You do not have sufficient funds");

                                    flag = 1;

                                }

                               
                            }
                            if (flag == 0)
                            {
                                Console.WriteLine("account number not found");
                            }
                        }
                                
                        else
                        {
                            Console.WriteLine("invalid amount entered, please try again");
                        }
                        break;

                    case 4:
                        
                        AccountData objAD = new AccountData();
                        Console.WriteLine("Enter your name");
                        objAD.AccountHolderName = Console.ReadLine();
                        Console.WriteLine("Enter your acc num");
                        objAD.AccountNumber = Console.ReadLine();
                        Console.WriteLine("How much balance do you want to add");
                        objAD.AccountBalance = Convert.ToInt32(Console.ReadLine());

                        if (objAD.AccountBalance >= 0)
                        {
                            BankAccount newaccount = new BankAccount(objAD);
                            acc_info.Add(newaccount);
                        }
                        else
                            Console.WriteLine("You can not add negative balance");


                        break;

                  









                }
                flag = 0;
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
