using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordina.YP.Logger.Business
{
    public abstract class BaseLogger : Ordina.YP.Logger.Business.ILogger
    {
        public abstract void Log(string textToLog);
    }
}
