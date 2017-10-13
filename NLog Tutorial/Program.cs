using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLog_Tutorial
{
    class Program
    {
        //Guide On Github Page for nLog 
        //https://github.com/nlog/nlog/wiki/Tutorial

        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            logger.Trace("Sample trace message");
            logger.Debug("Sample debug message");
            logger.Info("Sample informational message");
            logger.Warn("Sample warning message");
            logger.Error("Sample error message");
            logger.Fatal("Sample fatal error message");

            try
            {
                int a = 0;
                float number = 0 / a;
            }
            catch (Exception ex)
            {
                logger.Fatal(ex, "Division by 0");
                //throw;
            }
        }
    }
}
