namespace Singleton
{
    public class SingleThreadSingleton
    {
        private static SingleThreadSingleton _instance;

        private SingleThreadSingleton()
        {
            Identifier = Guid.NewGuid();
        }

        public static SingleThreadSingleton Instance
        {
            get
            {
                if (_instance is null)
                {
                    _instance = new SingleThreadSingleton();
                }

                return _instance;
            }
        }

        public Guid Identifier { get; set; }

        public static void Clear()
        {
            _instance = null;
        }
    }
}