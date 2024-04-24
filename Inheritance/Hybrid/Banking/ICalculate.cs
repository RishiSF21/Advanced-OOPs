using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking
{
    public interface ICalculate
    {
        public void Deposit(int amt);
        public void Withdraw(int amt);
        public void BalanceCheck();
    }
}