using Ordina.YP.Logger.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordina.YP.Logger.UI.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            LoggerProgram program;
            BaseLogger teGebruikenLogger;
            //ILogger teGebruikenLogger;

            //teGebruikenLogger = new ConsoleLogger();
            teGebruikenLogger = new FileLogger(@"c:\Temp\LogFile.log");
            program = new LoggerProgram(teGebruikenLogger);
            program.Start();
        }
    }
}
