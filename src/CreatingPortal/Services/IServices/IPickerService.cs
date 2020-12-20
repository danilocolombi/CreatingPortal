using CreatingPortal.Models.Core;
using CreatingPortal.Models.Pickers;
using Refit;
using System.Threading.Tasks;

namespace CreatingPortal.Services.IServices
{
    public interface IPickerService
    {
        [Post("/Pickers")]
        Task<ResultResponse> CreateAsync([Body] PickerCreationViewModel pickerCreationViewModel);

        [Put("/Pickers/{pickerId}")]
        Task<ResultResponse> UpdateAsync(int pickerId, [Body] PickerCreationViewModel pickerCreationViewModel);

        [Delete("/Pickers/{pickerId}")]
        Task<ResultResponse> DeleteAsync(int pickerId);

        [Get("/Pickers/{pickerId}")]
        Task<PickerViewModel> GetAsync(int pickerId);
    }
}
