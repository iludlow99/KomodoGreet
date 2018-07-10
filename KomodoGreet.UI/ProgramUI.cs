using System;
using KomodoGreet.Contracts;

namespace KomodoGreet.UI
{
    public class ProgramUI
    {
        private readonly IConsole _console;
        public Compute Compute;

        public ProgramUI(IConsole consoleForAllReadsAndWrites)
        {
            _console = consoleForAllReadsAndWrites;
            Compute = new Compute();
        }

        public void Run()
        {
            bool isRunning = true;

            while (isRunning)
            {
                try
                {
                    _console.Write("Command (addCustomer, seeAllCustomer, searchForCustomer, exitProgram): ");
                    var command = _console.ReadLine().ToLower().Trim();

                    if (String.IsNullOrWhiteSpace(command))
                    {
                        isRunning = false;
                    }
                    else if (command == "addcustomer")
                    {
                        AddCustomer();
                    }
                    else if (command == "seeallcustomer")
                    {
                        SeeAllCustomer();
                    }
                    else if (command == "searchforcustomer")
                    {
                        SearchForCustomer();
                    }
                    else if (command == "exitprogram")
                    {
                        ExitProgram();
                    }

                    //!Leave this at the bottom for spacing reasons!
                    _console.WriteLine("");

                }
                catch (Exception ex)
                {
                    _console.WriteLine($"{ex.Message}");
                }
            }
        }
    }
}