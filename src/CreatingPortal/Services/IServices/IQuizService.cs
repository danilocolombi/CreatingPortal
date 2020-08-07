using CreatingPortal.Models.Core;
using CreatingPortal.Models.Quizzes;
using Refit;
using System.Threading.Tasks;

namespace CreatingPortal.Services.IServices
{
    public interface IQuizService
    {
        [Post("/Quiz")]
        Task<ResultResponse> CreateAsync([Body] QuizCreationViewModel quizCreationViewModel);

        [Put("/Quiz/{quizId}")]
        Task<ResultResponse> UpdateAsync(int quizId, [Body] QuizCreationViewModel quizCreationViewModel);

        [Delete("/Quiz/{quizId}")]
        Task<ResultResponse> DeleteAsync(int quizId);

        [Get("/Quiz/{quizId}")]
        Task<QuizViewModel> GetAsync(int quizId);
    }
}
