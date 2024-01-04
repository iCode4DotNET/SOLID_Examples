using Newtonsoft.Json;

namespace SOLID_SRP
{
    public class DocumentSerializer
    {
        public object Serilize(object doc)
        {
            return JsonConvert.SerializeObject(doc);
        }
    }
}