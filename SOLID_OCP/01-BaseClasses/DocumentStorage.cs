namespace SOLID_OCP.BaseClasses
{



    public abstract class DocumentStorage
    {
        public abstract string GetData(string sourceFileName);

        public abstract void PersistDocument(object serializedDoc, string targetFileName);
    }


    public abstract class DocumentStorage1
    {
        public abstract string GetData(string sourceFileName);

    }


    public abstract class DocumentStorage2
    {
        public abstract void PersistDocument(object serializedDoc, string targetFileName);
    }


}
