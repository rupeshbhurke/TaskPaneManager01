namespace CommonUtilities.Helpers
{
    public class ThreadSafeWrapper<T>
    {
        private T _value;
        private readonly object _lock = new object();

        public ThreadSafeWrapper(T initialValue)
        {
            _value = initialValue;
        }

        // Gets the value in a thread-safe manner
        public T Value
        {
            get
            {
                lock (_lock)
                {
                    return _value;
                }
            }
        }

        // Sets the value in a thread-safe manner
        public void SetValue(T newValue)
        {
            lock (_lock)
            {
                _value = newValue;
            }
        }
    }

}