using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fh.Cof.App.Base.Bat;
using Fh.Cof.Csl.Logging;

namespace AutomaticLogger
{
	class AutomaticLoggerConsole : FhBaseConsole
    {
        internal AutomaticLoggerConsole()
            : base("ErrorApp", "AutomaticLogger")
        {
        }

        protected override void LogUsage()
        {
            FhLogging.LogInfo("De logging is gestard om: " + DateTime.Now);
        }

        /// <summary>
        /// Voert de verwerking van de batch uit. De commandline parameters staan in de Parameters-property.
        /// </summary>
        protected override void Execute()
        {
            for (int i = 0; i < 5; i++)
            {
                FhLogging.LogError("Biep Boop Watermeloen");
                Console.WriteLine("waterijsjes");
            }
        }

        protected override bool CheckParameters()
        {
            return true;
        }
    }
}
