using System;
using System.Collections.Generic;
using System.Text;

namespace Treino_Heranca1.Entities
{
    class SavingsAccount : Account
    {
        public double IncreasedRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double increasedRate)
            :base (number, holder, balance)
        {
            IncreasedRate = increasedRate;
        }

        public void UpdateBallance() {
            Balance += Balance * IncreasedRate;
        }

        public override void Withdraw(double amount)
        {
            Balance -= amount;
        }
    }
}
