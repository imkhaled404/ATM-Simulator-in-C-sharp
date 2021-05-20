namespace ATMSimulator.Interfaces
{
    public interface IDisplayService
    {
        void DisplayMenu(int actionNumber);
        int ReadAndValidateMenuOptions(int actionNumber);
        void Exit();
        bool ReplayYesNo(int biPass = 1);

        void PrintAtmWelcomeMessage();
    }
}
