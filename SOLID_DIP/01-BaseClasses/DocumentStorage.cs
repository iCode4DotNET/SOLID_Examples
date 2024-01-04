namespace SOLID_DIP
{
    public abstract class DocumentStorage : IInputRetriever, IInputPersister
    {
        public abstract string GetData(string sourceFileName);

        public abstract void PersistDocument(object serializedDoc, string targetFileName);
    }
}