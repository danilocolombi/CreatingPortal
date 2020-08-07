using CreatingPortal.Models.Core;
using CreatingPortal.Models.Pickers;
using Refit;
using System.Threading.Tasks;

namespace CreatingPortal.Services.IServices
{
    public interface IPickerService
    {
        [Post("/Picker")]
        Task<ResultResponse> CreateAsync([Body] PickerCreationViewModel pickerCreationViewModel);

        [Put("/Picker/{pickerId}")]
        Task<ResultResponse> UpdateAsync(int pickerId, [Body] PickerCreationViewModel pickerCreationViewModel);

        [Delete("/Picker/{pickerId}")]
        Task<ResultResponse> DeleteAsync(int pickerId);

        [Get("/Picker/{pickerId}")]
        Task<PickerViewModel> GetAsync(int pickerId);
    }
}
