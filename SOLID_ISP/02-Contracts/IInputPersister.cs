namespace SOLID_ISP
{
    public interface IInputPersister
    {
        void PersistDocument(object serializedDoc, string targetFileName);

    }
}