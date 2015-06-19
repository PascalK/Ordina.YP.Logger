using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordina.YP.Logger.Business
{
    public class ConsoleLogger : BaseLogger
    {
        public override void Log(string textToLog)
        {
            Console.WriteLine(textToLog);
        }
    }
}