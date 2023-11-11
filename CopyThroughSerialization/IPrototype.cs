namespace CopyThroughSerialization
{
    public interface IPrototype<T>
    {
        T DeepCopy();
    }
}
