// Task 1: Bank Account System with Custom Object Comparisons
// Task: Develop a BankAccount class that supports:

// 1. Custom String Representation (ToString() Override)
// Format: "Account: [AccountNumber], Balance: [Balance] USD"

// 2. Equality Check (Equals() and GetHashCode())
// Two accounts are equal if they have the same AccountNumber.

// 3. Overloaded + and - Operators for Transactions
// + should deposit money.
// - should withdraw money but prevent overdraft.

// 4. Comparison Operators (>, <, >=, <=)
// Compare accounts based on balance.

// class BankAccount
// {
//     private int _Accountnumber;
//     private decimal _Balance;

//     public BankAccount(int accountnumber,decimal balance)
//     {
//         this._Accountnumber = accountnumber;
//         this._Balance = balance;
//     }

//     public int Accountnumber
//     {
//         get { return _Accountnumber; }
//     }

//     public decimal Balance
//     {
//         get { return _Balance; }
//     }

//     public override string ToString()
//     {
//         return $"Account: {this.Accountnumber}, Balance: {this.Balance} USD";
//     }

//     public override bool Equals(object obj)
//     {

//         BankAccount other = (BankAccount)obj;
//         if (other.Accountnumber == this.Accountnumber) {
//             return true;
//         }

//         else {
//             return false;
//         }

//     }

//     public override int GetHashCode()
//     {
//         return this.Accountnumber.GetHashCode() ^ 6;
//     }

//     public static BankAccount operator +(BankAccount a,decimal b)
//     {
//         a._Balance += b;
//         return a;
//     }

//     public static BankAccount operator -(BankAccount a,decimal b)
//     {
//         if (b > a._Balance){
//             Console.WriteLine("Balance is lower than your entered money");
//             return a ;
//         }

//         else{
//             a._Balance -= b;
//             return a;
//         }    
//     }

//     public static bool operator <(BankAccount a,BankAccount b)
//     {
//         return (a < b);
//     }
//     public static bool operator >(BankAccount a, BankAccount b)
//     {
//         return !(a < b);
//     }

//     public static bool operator >=(BankAccount a, BankAccount b)
//     {
//         return (a >= b);
//     }

//     public static bool operator <=(BankAccount a, BankAccount b)
//     {
//         return !(a >= b);
//     }

// }


// class Program
// {

//     static void Main(string[] args)
//     {
//         BankAccount account = new BankAccount(15,1500);
//         Console.WriteLine(account.ToString());
//         BankAccount account1 = new BankAccount(15,1600);
//         Console.WriteLine($"first and second accounts are equal {account.Equals(account1)}");
//         Console.WriteLine($"First account Balance is after summing balance {account + 1500}");
//         Console.WriteLine($"");
//         account = account + 5;
//     }
// }

