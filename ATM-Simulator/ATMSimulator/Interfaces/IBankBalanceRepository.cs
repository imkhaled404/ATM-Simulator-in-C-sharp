using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATMSimulator.Entities;

namespace ATMSimulator.Interfaces
{
    public interface IBankBalanceRepository
    {
        List<Account> LoadBankBalanceToAccounts();
    }
}
