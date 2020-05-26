using System;
using System.IO;
using ConsoleLog4Net.Dependencies;
using log4net;
using log4net.Config;
using Unity;

namespace ConsoleLog4Net
{
    public static class Bootstrap
    {

        private static IUnityContainer _container;
        private const string Log4NetConfigFileName = "log4net.config";

        internal static void Init()
        {
            ConfigLogger();
            Logger.Log.Info("Init!");

            _container = new UnityContainer();
            _container.MyDependencyInjection();
        }

        internal static void ConfigLogger()
        {
            XmlConfigurator.ConfigureAndWatch(new FileInfo(AppDomain.CurrentDomain.BaseDirectory + Log4NetConfigFileName));
            Logger.Log = LogManager.GetLogger("AppLogger");
        }

        public static void Execute()
        {
            var program = _container.Resolve<ProgramStarter>();
            program.Run();
        }


    }
}
