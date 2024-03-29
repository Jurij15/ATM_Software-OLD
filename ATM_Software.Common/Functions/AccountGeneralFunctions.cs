﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ATM_Software.Common;
using System.Windows.Forms;
using ATM_Software.Common.Cores;

namespace ATM_Software.Common.Functions
{
    public static class AccountGeneralFunctions
    {
        public static string FindAccountByNumber(string accountNumber) //this will find the account from 1/2/3/4 based on the accountnumber
        {
            string acc1 = File.ReadAllText(Locations.Account1Number);
            string acc2 = File.ReadAllText(Locations.Account2Number);
            string acc3 = File.ReadAllText(Locations.Account3Number);
            string acc4 = File.ReadAllText(Locations.Account4Number);

            if (acc1 == accountNumber)
            {
                return "Account1";
            }
            else if (acc2 == accountNumber)
            {
                return "Account2";
            }
            else if (acc3 == accountNumber)
            {
                return "Account3";
            }
            else if (acc4 == accountNumber)
            {
                return "Account4";
            }
            else
            {
                return null;
            }
            return null;
        }
        public static string FindAccountByPIN(string accountPIN) //this will find the account from 1/2/3/4 based on the accountpin
        {
            string acc1 = File.ReadAllText(Locations.Account1PIN);
            string acc2 = File.ReadAllText(Locations.Account2PIN);
            string acc3 = File.ReadAllText(Locations.Account3PIN);
            string acc4 = File.ReadAllText(Locations.Account4PIN);

            if (acc1 == accountPIN)
            {
                return "Account1";
            }
            else if (acc2 == accountPIN)
            {
                return "Account2";
            }
            else if (acc3 == accountPIN)
            {
                return "Account3";
            }
            else if (acc4 == accountPIN)
            {
                return "Account4";
            }
            else
            {
                return null;
            }
            return null;
        }
        public static string GetAccountMoneyStat(string currentAcc)
        {
            string acc1 = File.ReadAllText(Locations.Account1MoneyStat);
            string acc2 = File.ReadAllText(Locations.Account2MoneyStat);
            string acc3 = File.ReadAllText(Locations.Account3MoneyStat);
            string acc4 = File.ReadAllText(Locations.Account4MoneyStat);

            if (currentAcc.Contains("1"))
            {
                return acc1;
            }
            else if (currentAcc.Contains("2"))
            {
                return acc2;
            }
            else if (currentAcc.Contains("3"))
            {
                return acc3;
            }
            else if (currentAcc.Contains("4"))
            {
                return acc4;
            }
            else
            {
                return null;
            }
        }
        public static string GetAccountMoneyStatFile(string currentAcc)
        {
            string acc1 = Locations.Account1MoneyStat;
            string acc2 = Locations.AccountMoneyStat;
            string acc3 = Locations.Account3MoneyStat;
            string acc4 = Locations.Account4MoneyStat;

            if (currentAcc.Contains("1"))
            {
                return acc1;
            }
            else if (currentAcc.Contains("2"))
            {
                return acc2;
            }
            else if (currentAcc.Contains("3"))
            {
                return acc3;
            }
            else if (currentAcc.Contains("4"))
            {
                return acc4;
            }
            else
            {
                return null;
            }
        }

        public static string GetCurrentAccount()
        {
            return configs.CurrentAccount;
        }

        public static string GetCurrentAccountName(string currentAcc)
        {
            string acc1 = File.ReadAllText(Locations.Account1Owner);
            string acc2 = File.ReadAllText(Locations.Account2Owner);
            string acc3 = File.ReadAllText(Locations.Account3Owner);
            string acc4 = File.ReadAllText(Locations.Account4Owner);

            if (currentAcc.Contains("1"))
            {
                return acc1;
            }
            else if (currentAcc.Contains("2"))
            {
                return acc2;
            }
            else if (currentAcc.Contains("3"))
            {
                return acc3;
            }
            else if (currentAcc.Contains("4"))
            {
                return acc4;
            }
            else
            {
                return null;
            }
            return null;
        }

        public static bool CheckAccountValid(string currentAcc)
        {
            string acc1 = File.ReadAllText(Locations.Account1Valid);
            string acc2 = File.ReadAllText(Locations.Account2Valid);
            string acc3 = File.ReadAllText(Locations.Account3Valid);
            string acc4 = File.ReadAllText(Locations.Account4Valid);

            if (currentAcc.Contains("1"))
            {
                if (acc1.Contains("true"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (currentAcc.Contains("2"))
            {
                if (acc2.Contains("true"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (currentAcc.Contains("3"))
            {
                if (acc3.Contains("true"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (currentAcc.Contains("4"))
            {
                if (acc4.Contains("true"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            return false;
        }

        public static void CheckCurrentAccountConfig()
        {
            if (configs.CurrentAccount == null)
            {
                Logger.LogError("ULOGIN", "CurrentAccount is NULL!");
                MessageBox.Show("CurrentAccount is null, please restart the app");
                Environment.Exit(0);
            }
        }
    }
}
