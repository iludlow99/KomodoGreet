using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoGreet.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var programUI = new ProgramUI(new RealConsole());
            programUI.Run();
        }
    }
}
