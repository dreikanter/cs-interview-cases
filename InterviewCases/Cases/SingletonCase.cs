namespace InterviewCases.Cases
{
    // Q: Implement a singleton pattern
    // A:

    // Basic implementation

    public sealed class Singleton
    {
        private static Singleton _instance;

        public static Singleton Instance
        {
            get { return _instance ?? (_instance = new Singleton()); }
        }

        private Singleton() { }
    }

    // Thread-safe implementation (preferable)

    public sealed class SafeSingleton
    {
        private static volatile SafeSingleton _instance;

        private static readonly object _locker = new object();

        public static SafeSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_locker)
                    {
                        if (_instance == null)
                        {
                            _instance = new SafeSingleton();
                        }
                    }
                }

                return _instance;
            }
        }

        private SafeSingleton()
        {
            // ...
        }
    }

    // A generic implementation:

    public sealed class GenericSingleton<T> where T : class, new()
    {
        private static readonly T _instance = new T();

        public static T Instance
        {
            get { return _instance; }
        }
    }

    // Comment: One caveat with any Singleton based on an Instance property 
    // is that you have to be careful if your class constructor has side effects.
    // If you hover over the Instance property in the debugger while in the middle 
    // of singleton construction (because you set a breakpoint in one of the side effects,
    // for example), you can actually execute the constructor again and cause all sorts 
    // of fun mind-boggling problems. This happens because the debugger (by default) 
    // evaluates properties automatically when you hover over them. – Dan Bryant
    // http://stackoverflow.com/questions/100081/whats-a-good-threadsafe-singleton-generic-template-pattern-in-c-sharp#comment9632913_100081
}
