using System.Threading.Tasks;

namespace GransteL.QnaService.Interfaces
{
    public interface IQnaService
    {
        Task<string> GetAnswerAsync(string question);
    }
}