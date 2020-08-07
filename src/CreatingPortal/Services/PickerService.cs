using CreatingPortal.Models.Core;
using CreatingPortal.Models.Pickers;
using CreatingPortal.Services.IServices;
using CreatingPortal.Utilities;
using Refit;
using System.Threading.Tasks;

namespace CreatingPortal.Services
{
    public class PickerService
    {
        private readonly IPickerService _pickerService;

        public PickerService()
        {
            _pickerService = RestService.For<IPickerService>(Config.API_BASE_ADDRESS);
        }

        public async Task<ResultResponse> CreateAsync(PickerCreationViewModel pickerCreationViewModel)
            => await _pickerService.CreateAsync(pickerCreationViewModel);

        public async Task<ResultResponse> UpdateAsync(int pickerId, PickerCreationViewModel pickerCreationViewModel)
            => await _pickerService.UpdateAsync(pickerId, pickerCreationViewModel);

        public async Task<ResultResponse> DeleteAsync(int pickerId)
            => await _pickerService.DeleteAsync(pickerId);

        public async Task<PickerViewModel> GetAsync(int pickerId)
          => await _pickerService.GetAsync(pickerId);
    }
}
