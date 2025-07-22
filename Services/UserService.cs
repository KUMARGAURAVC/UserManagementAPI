using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagementAPI.Models;

namespace UserManagementAPI.Services
{
    public class UserService
    {
        private readonly List<User> _users = new();

        public Task<List<User>> GetAllUsersAsync()
        {
            return Task.FromResult(_users); // Ensure _users is initialized
        }

        public Task<User?> GetUserByIdAsync(int id) =>
            Task.FromResult<User?>(_users.FirstOrDefault(u => u.Id == id));

        public Task AddUserAsync(User user)
        {
            _users.Add(user);
            return Task.CompletedTask;
        }

        public Task<User?> UpdateUserAsync(int id, User updatedUser)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                user.Name = updatedUser.Name;
                user.Email = updatedUser.Email;
            }
            return Task.FromResult<User?>(user);
        }

        public Task<bool> DeleteUserAsync(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                _users.Remove(user);
                return Task.FromResult(true);
            }
            return Task.FromResult(false);
        }
    }
}