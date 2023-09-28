namespace S1.InMemoryModel
{
    public interface IModelChanger
    {
        void NotifyChange(IModelChanger sender);
    }
}