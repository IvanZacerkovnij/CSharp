namespace Lesson19_12;

class Program
{
    abstract class Card
    {
        protected double balance = 0;
        protected double commision;

        public Card(double commision, double balance)
        {
            this.commision = commision;
            this.balance = balance;
        }
        public abstract double getBalance();
        
        public abstract void withdraw(double balance);
    }

    class MonoBank : Card
    {
        public MonoBank(double commision, double balance) : base(commision, balance){}
        
        public override double getBalance() 
        {
            Console.WriteLine($"Balance: {balance}");
            return balance; 
        }
        public override void withdraw(double amount)
        {
            double to_withdraw = (amount * commision)/ 100;
            to_withdraw += amount;

            if (to_withdraw > this.balance)
            {
                Console.WriteLine("Insufficient balance");
                return;
            }
            this.balance -= to_withdraw;
        }
    }
    class ATM
    {
        public void to_withdraw(Card card, double amount)
        {
            card.withdraw(amount);
        }
    }

    static void task1()
    {
        MonoBank  monoBank = new MonoBank(10.0, 100.0);
        ATM atm = new ATM();
        atm.to_withdraw(monoBank, 50);
        monoBank.getBalance();
    }
    
    static void Main(string[] args)
    {
        task1();
    }
}