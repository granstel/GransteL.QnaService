using System.Net;
using System.Threading.Tasks;
using NUnit.Framework;
using RestSharp;

namespace GransteL.QnaService.Tests
{
    [TestFixture]
    public class QnaServiceIntegrationTests
    {
        private QnaService _target;

        [SetUp]
        public void InitTest()
        {
            var webClient = new RestClient { Proxy = new WebProxy("127.0.0.1", 8888) };

            var configuration = new QnaConfiguration
            {
                UrlFormat = "https://westus.api.cognitive.microsoft.com/qnamaker/v2.0/knowledgebases/{0}/generateAnswer",
                Token = "%QNA_TOKEN%",
                KnowledgeBase = "your-kb-id"
            };

            var client = new QnaClient(webClient, configuration, new CustomJsonSerializer());

            _target = new QnaService(client, configuration);
        }

        [Test]
        [Ignore("Integration")]
        public async Task GetAnswer_Answer_Success()
        {
            var question = "hi";


            var answer = await _target.GetAnswerAsync(question);


            Assert.NotNull(answer);
        }
    }
}
