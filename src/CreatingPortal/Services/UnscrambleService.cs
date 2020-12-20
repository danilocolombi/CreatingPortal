using CreatingPortal.Models.Core;
using CreatingPortal.Models.Unscrambles;
using CreatingPortal.Services.IServices;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CreatingPortal.Services
{
    public class UnscrambleService
    {
        private readonly IUnscrambleService _unscrambleService;

        public UnscrambleService(string ApiAddress)
        {
            _unscrambleService = RestService.For<IUnscrambleService>(ApiAddress);
        }

        public async Task<ResultResponse> CreateAsync(UnscrambleCreationViewModel unscrambleCreationViewModel)
            => await _unscrambleService.CreateAsync(unscrambleCreationViewModel);

        public async Task<ResultResponse> UpdateAsync(int UnscrambleId, UnscrambleCreationViewModel unscrambleCreationViewModel)
            => await _unscrambleService.UpdateAsync(UnscrambleId, unscrambleCreationViewModel);

        public async Task<ResultResponse> DeleteAsync(int unscrambleId)
            => await _unscrambleService.DeleteAsync(unscrambleId);

        public async Task<UnscrambleViewModel> GetAsync(int unscrambleId)
          => await _unscrambleService.GetAsync(unscrambleId);

        public async Task<IEnumerable<ShuffledExercise>> GetShuffledExercisesAsync(int unscrambleId)
         => await _unscrambleService.GetShuffledExercisesAsync(unscrambleId);
    }
}
