namespace Singleton
{
    public class NaiveMultithreadSingleton
    {
        private static readonly object _lock = new object();
        private static NaiveMultithreadSingleton _instance;

        private NaiveMultithreadSingleton()
        {
            Identifier = Guid.NewGuid();
        }

        public static NaiveMultithreadSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        _instance = new NaiveMultithreadSingleton();
                    }
                }

                return _instance;
            }
        }

        public Guid Identifier { get; set; }
    }
}