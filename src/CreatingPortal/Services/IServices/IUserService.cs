using CreatingPortal.Models.Activities;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CreatingPortal.Services.IServices
{
    public interface IUserService
    {

        [Get("/Users/{userId}/Activities")]
        Task<IEnumerable<MyActivityViewModel>> GetUserActivitiesAsync(int userId);
    }
}
