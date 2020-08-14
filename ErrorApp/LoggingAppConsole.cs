using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fh.Cof.App.Base.Bat;

namespace ErrorApp
{
    /// <summary>
    /// Class binnen de batch waarin de verwerking gedaan wordt
    /// </summary>
    internal class LoggingAppConsole : FhBaseConsole
    {
        internal LoggingAppConsole()
            : base("ErrorApp", "LoggingApp")
        {
        }

        /// <summary>
        /// Checkt of de gebruiker de parameters juist heeft meegegeven.
        /// </summary>
        protected override bool CheckParameters()
        {

            return true;
        }

        /// <summary>
        /// Logt naar de Console hoe de applicatie opgestart moet worden.
        /// </summary>
        protected override void LogUsage()
        {
        }

        /// <summary>
        /// Voert de verwerking van de batch uit. De commandline parameters staan in de Parameters-property.
        /// </summary>
        protected override void Execute()
        {
            TestLogger testLogger = new TestLogger();


            // Display title as the C# console calculator app.
            Console.WriteLine("Console PagerDutyError\r");
            Console.WriteLine("------------------------\n");
            // Ask the user to choose an option.
            Console.WriteLine("Choose an option:");
            Console.WriteLine("\t1 - log info");
            Console.WriteLine("\t2 - log warning");
            Console.WriteLine("\t3 - log error");
            Console.WriteLine("\tany key to quit");
            TickTock(testLogger);
            Console.ReadLine();
        }

        private static void TickTock(TestLogger testLogger)
        {
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("logging at info level now");
                    testLogger.setLogging(LogLevel.Info);
                    break;
                case "2":
                    Console.WriteLine("logging at warning level now");
                    testLogger.setLogging(LogLevel.Warning);
                    break;
                case "3":
                    Console.WriteLine("logging at error level now");
                    testLogger.setLogging(LogLevel.Error);
                    break;
                default:
                    Console.WriteLine("input not valid");
                    break;
            }
        }
    }
}
