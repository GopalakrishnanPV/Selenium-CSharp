using log4net;

namespace reporting_and_logging
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ILog log = LogManager.GetLogger(typeof(Program));
			log.Debug("Test");
		}
	}
}