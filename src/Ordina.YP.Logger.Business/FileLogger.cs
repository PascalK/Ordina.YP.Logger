using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordina.YP.Logger.Business
{
    public class FileLogger : BaseLogger
    {
        private string fileNameToLogTo;

        public FileLogger(string fileNameToLogTo)
        {
            this.fileNameToLogTo = fileNameToLogTo;
            EnsureLogFolderExists();
        }
        private void EnsureLogFolderExists()
        {
            string directoryName;

            directoryName = Path.GetDirectoryName(fileNameToLogTo);
            if (!Directory.Exists(directoryName))
            {
                Directory.CreateDirectory(directoryName);
            }
        }

        public override void Log(string textToLog)
        {
            File.AppendAllText(fileNameToLogTo, textToLog + Environment.NewLine);
        }
    }
}