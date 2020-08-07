using CreatingPortal.Models.Core;
using CreatingPortal.Models.Unscrambles;
using Refit;
using System.Threading.Tasks;

namespace CreatingPortal.Services.IServices
{
    public interface IUnscrambleService
    {
        [Post("/Unscramble")]
        Task<ResultResponse> CreateAsync([Body] UnscrambleCreationViewModel unscrambleCreationViewModel);

        [Put("/Unscramble/{unscrambleId}")]
        Task<ResultResponse> UpdateAsync(int unscrambleId, [Body] UnscrambleCreationViewModel unscrambleCreationViewModel);

        [Delete("/Unscramble/{unscrambleId}")]
        Task<ResultResponse> DeleteAsync(int unscrambleId);

        [Get("/Unscramble/{unscrambleId}")]
        Task<UnscrambleViewModel> GetAsync(int unscrambleId);
    }
}
