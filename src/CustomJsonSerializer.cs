using GransteL.QnaService.Extensions;
using RestSharp.Serializers;

namespace GransteL.QnaService
{
    public class CustomJsonSerializer : ISerializer
    {
        public string Serialize(object obj)
        {
            ContentType = "application/json";

            var result = obj.Serialize();

            return result;
        }

        public string RootElement { get; set; }
        public string Namespace { get; set; }
        public string DateFormat { get; set; }
        public string ContentType { get; set; }
    }
}
