namespace SOLID_LSP
{
    public abstract class DocumentStorage
    {
        public abstract string GetData(string sourceFileName);

        public abstract void PersistDocument(object serializedDoc, string targetFileName);
    }
}