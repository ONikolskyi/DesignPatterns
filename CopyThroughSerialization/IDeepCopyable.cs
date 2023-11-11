namespace CopyThroughSerialization
{
    // use this way if you won't work with ": base" ctors
    public interface IDeepCopyable<T>
        where T : new()
    {
        void CopyTo(T target);

        public T DeepCopy()
        {
            T t = new T();
            CopyTo(t);
            return t;
        }
    }
}
