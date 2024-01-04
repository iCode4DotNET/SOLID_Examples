namespace SOLID_ISP
{
    public abstract class DocumentStorage : IInputRetriever, IInputPersister
    {
        public abstract string GetData(string sourceFileName);
        public abstract void PersistDocument(object serializedDoc, string targetFileName);
    }
}