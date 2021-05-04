using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace GransteL.QnaService.Models
{
    [JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Response
    {
        [JsonProperty]
        public AnswerModel[] Answers { get; set; }

        [JsonProperty]
        public Error Error { get; set; }
    }
}
