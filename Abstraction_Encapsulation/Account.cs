    internal class Account
    {
        private int _balance;

        public Account(int amount)
        {
            _balance = amount;
        }

        public void Withdraw(int amount)
        {
            _balance -= amount;
        }

        public void Deposit(int amount)
        {
            _balance += amount;
        }

        public int GetBalance()
        {
            return _balance;
        }

    }
