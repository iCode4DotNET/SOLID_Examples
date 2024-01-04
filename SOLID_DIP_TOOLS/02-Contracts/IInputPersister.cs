namespace SOLID_DIP
{
    public interface IInputPersister
    {
        void PersistDocument(object serializedDoc, string targetFileName);

    }
}