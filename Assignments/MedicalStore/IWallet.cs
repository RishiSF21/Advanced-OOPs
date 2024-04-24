using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore
{
    public interface IWallet
    {
        public int WalletBalance { get; }
        //Methods
        public void WalletRecharge(int amt);
        public void DeductBalance(int amt);
    }
}