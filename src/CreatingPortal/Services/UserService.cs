using CreatingPortal.Models.Activities;
using CreatingPortal.Services.IServices;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CreatingPortal.Services
{
    public class UserService
    {
        private readonly IUserService _userService;

        public UserService(string ApiAddress)
        {
            _userService = RestService.For<IUserService>(ApiAddress);
        }

        public async Task<IEnumerable<MyActivityViewModel>> GetUserActivitiesAsync(int userId)
         => await _userService.GetUserActivitiesAsync(userId);

    }
}
