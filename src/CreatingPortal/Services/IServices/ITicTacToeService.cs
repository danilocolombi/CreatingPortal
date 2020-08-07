using CreatingPortal.Models.Core;
using CreatingPortal.Models.TicTacToes;
using Refit;
using System.Threading.Tasks;

namespace CreatingPortal.Services.IServices
{
    public interface ITicTacToeService
    {
        [Post("/TicTacToe")]
        Task<ResultResponse> CreateAsync([Body] TicTacToeCreationViewModel ticTacToeCreationViewModel);

        [Put("/TicTacToe/{ticTacToeId}")]
        Task<ResultResponse> UpdateAsync(int ticTacToeId, [Body] TicTacToeCreationViewModel ticTacToeCreationViewModel);

        [Delete("/TicTacToe/{ticTacToeId}")]
        Task<ResultResponse> DeleteAsync(int ticTacToeId);

        [Get("/TicTacToe/{ticTacToeId}")]
        Task<TicTacToeViewModel> GetAsync(int ticTacToeId);
    }
}
