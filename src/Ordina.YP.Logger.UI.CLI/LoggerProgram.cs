using Ordina.YP.Logger.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordina.YP.Logger.UI.CLI
{
    class LoggerProgram
    {
        protected readonly BaseLogger logger;
        //protected readonly ILogger logger;

        //public LoggerProgram(ILogger logger)
        public LoggerProgram(BaseLogger logger)
        {
            this.logger = logger;
        }

        public void Start()
        {
            bool keepGoing;

            keepGoing = true;
            do
            {
                string textToLog;

                Console.WriteLine("Welke tekst wilt u loggen?");
                textToLog = Console.ReadLine();
                logger.Log(textToLog);

                System.Console.Write("Wilt u nog een regel loggen (j)? ");
                keepGoing = System.Console.ReadLine().ToLowerInvariant() == "j";
            }
            while (keepGoing);
        }
    }
}
