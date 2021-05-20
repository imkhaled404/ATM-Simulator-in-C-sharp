using Ninject.Modules;
using ATMSimulator.Interfaces;
using  ATMSimulator.Repository;
using ATMSimulator.Services;

namespace ATMSimulator
{
    public class AtmSimulatorModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IBankBalanceRepository>().To<BankBalanceRepository>();
            Bind<ITransactionService>().To<TransactionService>();
            Bind<IDisplayService>().To<DisplayService>();
        }
    }
}
