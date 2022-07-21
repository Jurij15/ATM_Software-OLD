﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ATM_Software.Common.Cores
{
    public static class Locations
    {
        public static string baseFolder = @"Data/";
        public static string baseNews = baseFolder + "News/";
        public static string accountsBase = @"Accounts/";

        public static string account1directory = "Account1/";
        public static string account2directory = "Account2/";
        public static string account3directory = "Account3/";
        public static string account4directory = "Account4/";

        public static string Account1base = baseFolder + accountsBase + account1directory;
        public static string Account2base = baseFolder + accountsBase + account2directory;
        public static string Account3base = baseFolder + accountsBase + account3directory;
        public static string Account4base = baseFolder + accountsBase + account4directory;

        public static string AccountNumber = "number";
        public static string AccountPIN = "pin";
        public static string AccountOwner = "name";
        public static string AccountMoneyStat = "moneyStat";

        //files
        //account 1 stuff
        public static string Account1Number = Account1base + AccountNumber;
        public static string Account1PIN = Account1base + AccountPIN;
        public static string Account1Owner = Account1base + AccountOwner;
        public static string Account1MoneyStat = Account1base + AccountMoneyStat;

        //account 2 stuff
        public static string Account2Number = Account2base + AccountNumber;
        public static string Account2PIN = Account2base + AccountPIN;
        public static string Account2Owner = Account2base + AccountOwner;
        public static string Account2MoneyStat = Account2base + AccountMoneyStat;

        //account 3 stuff
        public static string Account3Number = Account3base + AccountNumber;
        public static string Account3PIN = Account3base + AccountPIN;
        public static string Account3Owner = Account3base + AccountOwner;
        public static string Account3MoneyStat = Account3base + AccountMoneyStat;

        //account 4 stuff
        public static string Account4Number = Account4base + AccountNumber;
        public static string Account4PIN = Account4base + AccountPIN;
        public static string Account4Owner = Account4base + AccountOwner;
        public static string Account4MoneyStat = Account4base + AccountMoneyStat;

        public static string NewsFile = baseNews + "news";

        //this will be used for when i remake the login system AGAIN
        public static List<string> AccountsNumbers = new List<string>
        {
                Locations.Account1Number,
                Locations.Account2Number,
                Locations.Account3Number,
                Locations.Account4Number
        };

        public static List<string> AccountsPINS = new List<string>
        {
                Locations.Account1Number,
                Locations.Account2Number,
                Locations.Account3Number,
                Locations.Account4Number
        };
    } 
}