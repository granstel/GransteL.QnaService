namespace GransteL.QnaService.Extensions
{
    public static class StringExtensions
    {
        private const string EncodedQuotes = "&quot;";

        public static string Sanitize(this string answer)
        {
            return answer?.Replace(EncodedQuotes, "\"");
        }
    }
}
