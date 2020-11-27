using System;

namespace classes {
    class Program {
        static void Main (string[] args) {
            var account = new BankAccount ("xmz", 38630);
            Console.WriteLine ($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
            account.MakeWithDrawal (500, DateTime.Now, "Rent payment");
            Console.WriteLine (account.Balance);
            account.MakeDeposit (100, DateTime.Now, "Friend paid me back");
            Console.WriteLine (account.Balance);
            try {
                account.MakeWithDrawal (75000, DateTime.Now, "Attempt to overdraw");
            } catch (InvalidOperationException e) {
                Console.WriteLine ("Exception caught trying to overdraw");
                Console.WriteLine (e.ToString ());
            }
            try {
                var invalidAccount = new BankAccount ("invalid", -55);
            } catch (ArgumentOutOfRangeException e) {
                Console.WriteLine ("Exception caught creating account with negative balance");
                Console.WriteLine (e.ToString ());
            }
            Console.WriteLine (account.GetAccountHistory ());
        }
    }
}