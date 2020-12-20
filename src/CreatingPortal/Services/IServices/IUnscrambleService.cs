using CreatingPortal.Models.Core;
using CreatingPortal.Models.Unscrambles;
using Refit;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CreatingPortal.Services.IServices
{
    public interface IUnscrambleService
    {
        [Post("/Unscrambles")]
        Task<ResultResponse> CreateAsync([Body] UnscrambleCreationViewModel unscrambleCreationViewModel);

        [Put("/Unscrambles/{unscrambleId}")]
        Task<ResultResponse> UpdateAsync(int unscrambleId, [Body] UnscrambleCreationViewModel unscrambleCreationViewModel);

        [Delete("/Unscrambles/{unscrambleId}")]
        Task<ResultResponse> DeleteAsync(int unscrambleId);

        [Get("/Unscrambles/{unscrambleId}")]
        Task<UnscrambleViewModel> GetAsync(int unscrambleId);

        [Get("/Unscrambles/ShuffledExercises/{unscrambleId}")]
        Task<IEnumerable<ShuffledExercise>> GetShuffledExercisesAsync(int unscrambleId);
    }
}
