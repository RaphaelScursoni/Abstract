using System;
using System.Collections.Generic;
using System.Text;

namespace Treino_Heranca1.Entities
{
    abstract class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account() { }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        //COMO POSSO FAZER UMA FUNÇÃO SER DIFERENTE PARA 
        //AS CLASSES E SUBCLASSES?
        //Basta na classe "Pai" colocar o -VIRTUAL- 
        //Na classe "Filho" colocar -OVERRIDE- 
        //Assim criando uma sobreposição.

        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
