using System.Threading.Tasks;
using GransteL.QnaService.Models;

namespace GransteL.QnaService.Interfaces
{
    public interface IQnaClient
    {
        Task<Response> GetAnswerAsync(string knowledgeBase, string question);
    }
}