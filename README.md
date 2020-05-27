#### # Readme.md

### Console app and logger: Good practices 

- Net Framework 4.7
- Unity (resolver container)
- log4net library (v2.0.5)

This repository contains the simple solution to easy configure a logger in your console apps (valid for web apps as well) and we resolve the dependency injection for unit and integration tests.

> define Logger as static 

```javascript
    public static class Logger
    {
        public static ILog Log { get; set; }

    }
```


> initializated in the Bootstrap class

```javascript
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
```

We´ve separated the initization of our Logger and the dependencies of our project. 

In the test layer we might use a mock of the Logger:
```javascript
        private ILog _mockLog;

        [SetUp]
        public void Setup()
        {
            _mockLog = MockRepository.GenerateMock<ILog>();
            _mockLog.Expect(e => e.Debug(Arg<object>.Is.Anything)).Repeat.Once();
            Logger.Log = _mockLog;
```
